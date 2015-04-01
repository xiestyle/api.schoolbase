using api.schoolbase.bll;
using api.schoolbase.Filters;
using api.schoolbase.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace api.schoolbase.Controllers
{
    /// <summary>
    /// 7.校本资源库
    /// </summary>
    [Auth]
    [RoutePrefix("resource_school")]
    public class ResourceSchoolController : ApiControllerBase
    {
        /// <summary>
        /// 7.1.获取资源列表
        /// </summary>
        /// <param name="source"></param>
        /// <param name="access_token"></param>
        /// <param name="specid"></param>
        /// <param name="gid"></param>
        /// <param name="sid"></param>
        /// <param name="chapterid"></param>
        /// <param name="skey"></param>
        /// <param name="count"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        [Route("resource.json")]
        [HttpGet]
        public IHttpActionResult resource(string source, string access_token,string schid, int specid = 0, int gid = 0, int sid = 0, int cid = 0, string skey = "", int count = 20, int page = 1)
        {
            var userobj = user.getUserByToken(access_token);
            
            long total_number = 0;
            var list = resource_school.getlist(schid, specid, gid, sid, cid, skey, page, count, out total_number).Select(r => new { 
                id = r.SERID, 
                title = r.ResTitle,
                specid = r.SpecialtyID,
                gid = r.GRAID,
                sid= r.SubjectID,
                cid = r.SclassID,
                nodepath = r.NodePath,
                filetype = string.IsNullOrEmpty(r.FileType) ? "" : r.FileType.Replace(".", ""),
                filesize = r.FileSize, 
                dtime = r.Dtime.ToString("yyyy-MM-dd HH:mm:ss"),
                uid=r.UID,
                uname=r.UserName,
                img = ConfigurationManager.AppSettings["WEB_preview_img"],
                score =r.NumScore==0?0:Math.Round((decimal)r.TotalScore/r.NumScore,1)
            }).ToArray();
            
            return Ok(new
            {
                status = 0,
                msg = "接口请求成功",
                result = new
                {
                    code = "0",
                    list = list,
                    total_number = total_number
                }
            });
        }

        /// <summary>
        /// 7.2.获取收藏列表
        /// </summary>
        /// <param name="source"></param>
        /// <param name="access_token"></param>
        /// <param name="count"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        [Route("resource/collect.json")]
        [HttpGet]
        public IHttpActionResult resource_collect(string source, string access_token, int count = 20, int page = 1)
        {
            var userobj = user.getUserByToken(access_token);

            long total_number = 0;
            string schid = userobj.schid;
            long uid = userobj.uid;
            var list = resource_school.getmycollectlist(schid, uid, page, count, out total_number).Select(r => new
            {
                id = r.SERID,
                title = r.ResTitle,
                specid = r.SpecialtyID,
                gid = r.GRAID,
                sid = r.SubjectID,
                cid = r.SclassID,
                nodepath = r.NodePath,
                filetype = string.IsNullOrEmpty(r.FileType) ? "" : r.FileType.Replace(".", ""),
                filesize = r.FileSize,
                dtime = r.Dtime.ToString("yyyy-MM-dd HH:mm:ss"),
                uid = r.UID,
                uname = r.UserName,
                img = ConfigurationManager.AppSettings["WEB_preview_img"],
                score = r.NumScore == 0 ? 0 : Math.Round((decimal)r.TotalScore / r.NumScore, 1)
            }).ToArray();
                
            return Ok(new
            {
                status = 0,
                msg = "接口请求成功",
                result = new
                {
                    code = "0",
                    list = list,
                    total_number = total_number
                }
            });
        }

        /// <summary>
        /// 7.3.获取资源详细
        /// </summary>
        /// <param name="source"></param>
        /// <param name="access_token"></param>
        /// <param name="rid"></param>
        /// <returns></returns>
        [Route("resource/show.json")]
        [HttpGet]
        public IHttpActionResult resource_show(string source, string access_token, long rid)
        {
            var obj = resource_school.getResItem(rid);
            if (obj == null)
            {
                return Ok(new
                {
                    status = 0,
                    msg = "接口请求成功",
                    result =GetEMsg("070301")
                });
            }
            else
            {
                var resfile = resource_school.getFileInfo(obj.FileID);
                string filepath = "";
                if (!string.IsNullOrEmpty(resfile.FilePath))
                {
                    filepath = Tools.FilePath(resfile.FilePath);
                }
                var carr = schoolbll.getSclassByNodePath(obj.NodePath).Select(r => new {id = r.SERID,name = r.Sname }).ToArray();
                return Ok(new{
                       status = 0,
                       msg = "接口请求成功",
                       result = new
                       {
                           code = "0",
                           id = obj.SERID,
                           title = obj.ResTitle,
                           specid=obj.SpecialtyID,
                           specname = schoolbll.getSpecName(obj.SpecialtyID),
                           gid= obj.GRAID,
                           gname = schoolbll.getGradeName(obj.GRAID),
                           sid = obj.SubjectID,
                           sname = schoolbll.getSubjectName(obj.SubjectID),
                           chapterarr = carr,
                           filetype =string.IsNullOrEmpty(obj.FileType)?"":obj.FileType.Replace(".", ""),
                           des = obj.ResDes,
                           filesize = obj.FileSize,
                           dtime = obj.Dtime.ToString("yyyy-MM-dd HH:mm:ss"),
                           filepath = filepath,
                           img = ConfigurationManager.AppSettings["WEB_preview_img"],
                           score = obj.NumScore == 0 ? 0 : Math.Round((decimal)obj.TotalScore / obj.NumScore, 1)
                       }
                   });
            }
            
        }

        /// <summary>
        /// 7.4.添加收藏
        /// </summary>
        /// <param name="source"></param>
        /// <param name="access_token"></param>
        /// <param name="name"></param>
        /// <param name="did"></param>
        /// <returns></returns>
        [Route("resource/collect/add.json")]
        [HttpPost]
        public IHttpActionResult resource_collect_add(CollectModel model)
        {
            if (!ModelState.IsValid || model == null)
            {
                return Ok(new
                {
                    status = 0,
                    msg = "接口请求成功",
                    result = GetEMsg("010001")
                });
            }
            var userobj = user.getUserByToken(model.access_token);
            int _code = resource_school.collect_add(model.rid, userobj.uid);
            object _result = new object();
            switch (_code)
            {
                case 0:
                    _result = new { code = "0" };
                    break;
                case 1:
                    _result = GetEMsg("070401");
                    break;
                case 2:
                    _result = GetEMsg("070402");
                    break;
                default:
                    _result = GetEMsg("010002");
                    break;
            }
            return Ok(new
            {
                status = 0,
                msg = "接口请求成功",
                result = _result
            });
        }

        /// <summary>
        /// 7.5.取消收藏
        /// </summary>
        /// <param name="source"></param>
        /// <param name="access_token"></param>
        /// <param name="name"></param>
        /// <param name="did"></param>
        /// <returns></returns>
        [Route("resource/collect/cancel.json")]
        [HttpPost]
        public IHttpActionResult resource_collect_cancel(CollectModel model)
        {
            if (!ModelState.IsValid || model == null)
            {
                return Ok(new
                {
                    status = 0,
                    msg = "接口请求成功",
                    result = GetEMsg("010001")
                });
            }
            var userobj = user.getUserByToken(model.access_token);
            int _code = resource_school.collect_cancel(model.rid, userobj.uid);
            object _result = new object();
            switch (_code)
            {
                case 0:
                    _result = new { code = "0" };
                    break;
                case 1:
                    _result = GetEMsg("070501");
                    break;
                case 2:
                    _result = GetEMsg("070502");
                    break;
                default:
                    _result = GetEMsg("010002");
                    break;
            }
            return Ok(new
            {
                status = 0,
                msg = "接口请求成功",
                result = _result
            });
        }


        /// <summary>
        /// 7.5.获取评论列表
        /// </summary>
        /// <param name="source"></param>
        /// <param name="access_token"></param>
        /// <param name="count"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        [Route("resource/comment/show.json")]
        [HttpGet]
        public IHttpActionResult resource_comment_show(string source, string access_token,long rid, int count = 20, int page = 1)
        {
            var obj = resource_school.getResItem(rid);
            if (obj == null) { 
                return Ok(new
                {
                    status = 0,
                    msg = "接口请求成功",
                    result = GetEMsg("070601")
                });
            }
            var userobj = user.getUserByToken(access_token);
            long total_number = 0;
            string schid = userobj.schid;
            long uid = userobj.uid;
            var list = resource_school.getcommentlist(rid, page, count, out total_number).Select(r => new
            {
                id = r.SerID,
                content = r.remarkcontent,
                score = r.Score,
                dtime = (r.DateAndTime??DateTime.MinValue).ToString("yyyy-MM-dd HH:mm:ss"),
                uid = r.UID,
                username = r.username
            }).ToArray();
               
            return Ok(new
            {
                status = 0,
                msg = "接口请求成功",
                result = new
                {
                    code = "0",
                    list = list,
                    total_number = total_number
                }
            });
        }

        /// <summary>
        /// 7.6.添加评论
        /// </summary>
        /// <param name="source"></param>
        /// <param name="access_token"></param>
        /// <param name="name"></param>
        /// <param name="did"></param>
        /// <returns></returns>
        [Route("resource/comment/add.json")]
        [HttpPost]
        public IHttpActionResult resource_comment_add(resourceCommentModel model)
        {
            if (!ModelState.IsValid || model == null)
            {
                return Ok(new
                {
                    status = 0,
                    msg = "接口请求成功",
                    result = GetEMsg("010001")
                });
            }
            var userobj = user.getUserByToken(model.access_token);
            var obj = resource_school.comment_add(model.rid, userobj.uid, model.content, model.score);
            object _result = new object();
            switch (obj)
            {
                case 0:
                    _result = new { code = "0" };
                    break;
                case 1:
                    _result = GetEMsg("070701");
                    break;
                case 2:
                    _result = GetEMsg("070702");
                    break;
                default:
                    _result = GetEMsg("010002");
                    break;
            }
            return Ok(new
            {
                status = 0,
                msg = "接口请求成功",
                result = _result
            });
        }
    }
    
}
