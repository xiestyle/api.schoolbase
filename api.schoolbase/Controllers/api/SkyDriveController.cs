using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using api.schoolbase.bll;
using api.schoolbase.Filters;
using api.schoolbase.Models;
using System.Web;
using System.Text.RegularExpressions;
using System.IO;

namespace api.schoolbase.Controllers
{
    /// <summary>
    /// 6.云盘
    /// </summary>
    [RoutePrefix("skydrive")]
    [Auth]
    public class SkyDriveController : ApiControllerBase
    {
        /// <summary>
        /// 6.1.获取目录文件
        /// </summary>
        /// <param name="source"></param>
        /// <param name="access_token"></param>
        /// <param name="did"></param>
        /// <param name="type"></param>
        /// <param name="count"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        [Route("directory_and_file.json")]
        [HttpGet]
        public IHttpActionResult directory_and_file(string source, string access_token, string did = "", int type = 0, int count = 20, int page = 1)
        {
            var userobj = user.getUserByToken(access_token);
            
            if (count < 1) { count = 20; }
            else if (count > 200) { count = 200; }

            string parentdir = "";      //父目录id
            string parentdirname = "";  //父目录名称
            string dirname = "";        //当前目录名称
            if (!string.IsNullOrEmpty(did))
            {
                var folderobj = skydrive.getFolder(did);
                if (folderobj == null)
                {
                    return Ok(new
                    {
                        status = 0,
                        msg = "接口请求成功",
                        result = GetEMsg("060101")
                    });
                }
                else
                {
                    parentdir = string.IsNullOrEmpty(folderobj.parent_uuid) ? "" : folderobj.parent_uuid;
                    if (parentdir != "") { 
                        var parentfolderobj = skydrive.getFolder(folderobj.parent_uuid);
                        parentdirname = string.IsNullOrEmpty(parentfolderobj.folder_name) ? "" : parentfolderobj.folder_name;
                    }
                    
                    dirname = string.IsNullOrEmpty(folderobj.folder_name) ? "" : folderobj.folder_name;
                }
            }

            var fileList = skydrive.GetFileList((int)userobj.uid, type, did);
            int maxpage = (int)Math.Ceiling((double)(fileList.Count / count));
            page = page > maxpage ? maxpage : page;
            page = page < 1 ? 1 : page;
            page--;
            var fl = fileList.Skip(count * page).Take(count);
            return Ok(new
            {
                status = 0,
                msg = "接口请求成功",
                result = new
                {
                    code = "0",
                    parentdirname=parentdirname,
                    parentdir = parentdir,
                    dirname = dirname,
                    list = fl,
                    total_number = fileList.Count
                }
            });
        }
        /// <summary>
        /// 6.2.新建目录
        /// </summary>
        /// <param name="source"></param>
        /// <param name="access_token"></param>
        /// <param name="name"></param>
        /// <param name="did"></param>
        /// <returns></returns>
        [Route("directory/create.json")]
        [HttpPost]
        public IHttpActionResult directory_create(directory_createModel model)
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
            var obj = skydrive.addFolder((int)userobj.uid, model.name, model.did);
            object _result = new object();
            switch (obj.Key)
            {
                case 0:
                    _result = new { code = "0" };
                    break;
                case 3:
                    _result = GetEMsg("060203");//目录id不存在
                    break;
                case 1:
                    _result = GetEMsg("060201");//文件目录名称已存在
                    break;
                default:
                    _result = GetEMsg("060202");//创建失败
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
        /// 6.3.修改目录名称
        /// </summary>
        /// <param name="source"></param>
        /// <param name="access_token"></param>
        /// <param name="name"></param>
        /// <param name="did"></param>
        /// <returns></returns>
        [Route("directory/update.json")]
        [HttpPost]
        public IHttpActionResult directory_update(directory_updateModel model)
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
            var obj = skydrive.editFolder((int)userobj.uid, model.name, model.did);
            object _result = new object();
            switch (obj.Key)
            {
                case 0:
                    _result = new { code = "0" };
                    break;
                case 1:
                    _result = GetEMsg("060301");
                    break;
                case 2:
                    _result = GetEMsg("060302");
                    break;
                default:
                    _result = GetEMsg("060303");
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
        /// 6.4.删除目录
        /// </summary>
        /// <param name="source"></param>
        /// <param name="access_token"></param>
        /// <param name="did"></param>
        /// <returns></returns>
        [Route("directory/destroy.json")]
        [HttpPost]
        public IHttpActionResult directory_destroy(directory_destroyModel model)
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
            var obj = skydrive.delFolder((int)userobj.uid, model.did);
            object _result = new object();
            switch (obj.Key)
            {
                case 0:
                    _result = new { code = "0" };
                    break;
                case 1:
                    _result = GetEMsg("060401");
                    break;
                default:
                    _result = GetEMsg("060402");
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
        /// 6.5.文件上传
        /// </summary>
        /// <param name="source"></param>
        /// <param name="access_token"></param>
        /// <param name="filename"></param>
        /// <param name="did"></param>
        /// <returns></returns>
        [Route("file/upload.json")]
        [HttpPost]
        public HttpResponseMessage file_upload()
        {
            HttpRequest request = HttpContext.Current.Request;
            HttpPostedFile file = HttpContext.Current.Request.Files["filedata"];
            string access_token = request.Params["access_token"];
            var userobj = user.getUserByToken(access_token);
            if (request.Params["filename"] == null || file == null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, new
                {
                    status = 0,
                    msg = "接口请求成功",
                    result = GetEMsg("010001")
                });
            }
            string filename = request.Params["filename"];
            if (filename.Length > 50)
            {
                return Request.CreateResponse(HttpStatusCode.OK, new
                {
                    status = 0,
                    msg = "接口请求成功",
                    result = GetEMsg("060501")
                });
            }
            if (file.ContentLength > 104857600)//100mb
            {
                return Request.CreateResponse(HttpStatusCode.OK, new
                {
                    status = 0,
                    msg = "接口请求成功",
                    result = GetEMsg("060502")
                });
            }
            string did = request.Params["did"];
            if (!string.IsNullOrEmpty(did) && !skydrive.isExitsFolder(did))
            {
                return Request.CreateResponse(HttpStatusCode.OK, new
                {
                    status = 0,
                    msg = "接口请求成功",
                    result = GetEMsg("060503")
                });
            }


            byte[] buffer = new byte[file.ContentLength];
            Stream fs = file.InputStream;
            fs.Read(buffer, 0, file.ContentLength);
            int i = 0;
            try
            {
                SchoolBaseServer.SchoolBaseSoapClient client = new SchoolBaseServer.SchoolBaseSoapClient();
                i = client.UploadZipFile(userobj.userid, buffer, filename, file.FileName.Substring(file.FileName.LastIndexOf('.')), did);
            }
            catch (Exception){}
            finally
            {
                fs.Close();
            }

            return Request.CreateResponse(HttpStatusCode.OK, new
            {
                status = 0,
                msg = "接口请求成功",
                result = new
                {
                    code = i == 1 ? "0" : GetEMsg("060504"),
                }
            });
        }

        /// <summary>
        /// 6.6.文件重命名
        /// </summary>
        /// <param name="source"></param>
        /// <param name="access_token"></param>
        /// <param name="fid"></param>
        /// <param name="filename"></param>
        /// <returns></returns>
        [Route("file/rename.json")]
        [HttpPost]
        public IHttpActionResult file_rename(file_renameModel model)
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
            var obj = skydrive.renameFile((int)userobj.uid, model.fid, model.filename);
            object _result = new object();
            switch (obj.Key)
            {
                case 0:
                    _result = new { code = "0" };
                    break;
                case 1:
                    _result = GetEMsg("060601");
                    break;
                case 2:
                    _result = GetEMsg("060602");
                    break;
                default:
                    _result = GetEMsg("060603");
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
        /// 6.7.删除文件
        /// </summary>
        /// <param name="source"></param>
        /// <param name="access_token"></param>
        /// <param name="fid"></param>
        /// <returns></returns>
        [Route("file/destroy.json")]
        [HttpPost]
        public IHttpActionResult file_destroy(file_destroyModel model)
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
            if (model.fids.Split(',').Length>20) {
                return Ok(new
                {
                    status = 0,
                    msg = "接口请求成功",
                    result = GetEMsg("060701")
                });
            }
            var userobj = user.getUserByToken(model.access_token);
            var obj = skydrive.delFile((int)userobj.uid, model.fids);
            object _result = new object();
            switch (obj.Key)
            {
                case 0:
                    _result = new { code = "0" };
                    break;
                default:
                    _result = GetEMsg("060702");
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
        /// 6.8.获取文件详细
        /// </summary>
        /// <param name="source"></param>
        /// <param name="access_token"></param>
        /// <param name="fid"></param>
        /// <returns></returns>
        [Route("file/show.json")]
        [HttpGet]
        public IHttpActionResult file_show(string source, string access_token, string fid)
        {
            var userobj = user.getUserByToken(access_token);
            var obj = skydrive.showFile((int)userobj.uid, fid);
            if (obj == null)
            {
                return Ok(new
                {
                    status = 0,
                    msg = "接口请求成功",
                    result = GetEMsg("060801")
                });
            }
            else
            {
                return Ok(new
                {
                    status = 0,
                    msg = "接口请求成功",
                    result = new
                    {
                        code = "0",
                        id = obj.id,
                        title = obj.title,
                        ftype = obj.filetype,
                        des = obj.des,
                        filesize = obj.filesize,
                        dtime = obj.dtime,
                        filepath = skydrive.FilePath(obj.filepath, userobj.schid)
                    }
                });
            }

        }

        
    }
    
}
