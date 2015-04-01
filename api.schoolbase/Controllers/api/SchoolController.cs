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
    /// 5.学校基础信息
    /// </summary>
    [RoutePrefix("school")]
    [Auth]
    public class SchoolController : ApiControllerBase
    {

        /// <summary>
        /// 5.1.获取学校信息
        /// </summary>
        /// <returns></returns>
        [Route("show.json")]
        [HttpGet]
        public IHttpActionResult show(string source, string access_token,string schid)
        {
            var obj = schoolbll.getSchoolById(schid);
            if (obj == null)
            {
                return Ok(new
                {
                    status = 0,
                    msg = "接口请求成功",
                    result = GetEMsg("050101")
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
                        id = obj.SchSerID,
                        schoolname = obj.SchName,
                        logourl = Tools.FilePath(obj.SchLogo)
                    }
                });
            }
        }

        /// <summary>
        /// 5.2.获取专业
        /// </summary>
        /// <returns></returns>
        [Route("specialty.json")]
        [HttpGet]
        public IHttpActionResult specialty(string source, string access_token, string schid)
        {
            var obj = schoolbll.getSchoolById(schid);
            if (obj == null)
            {
                return Ok(new
                {
                    status = 0,
                    msg = "接口请求成功",
                    result = GetEMsg("050201")
                });
            }
            var list = schoolbll.getSpecBySchId(schid).Select(r => new { 
                id = r.SERID, 
                specname = r.SpecName,
                type=r.SPEID==3?2:1//speid：3代表公共课程  返回1：非公共课程专业 2：公共课程专业
            }).ToArray();
            return Ok(new
            {
                status = 0,
                msg = "接口请求成功",
                result = new
                {
                    code = "0",
                    list = list,
                    total_number = list.Length
                }
            });
        }

        /// <summary>
        /// 5.3.获取年级
        /// </summary>
        /// <returns></returns>
        [Route("grade.json")]
        [HttpGet]
        public IHttpActionResult grade(string source, string access_token, string schid,long specid)
        {
            if (!schoolbll.yz_specid(schid, specid)) {
                return Ok(new
                {
                    status = 0,
                    msg = "接口请求成功",
                    result = GetEMsg("050301")
                });
            }
            var list = schoolbll.getGrade(schid, specid).Select(r => new { id = r.GRAID, gradename = r.GradeName }).ToArray();
            return Ok(new
            {
                status = 0,
                msg = "接口请求成功",
                result = new
                {
                    code = "0",
                    list = list,
                    total_number = list.Length
                }
            });
        }

        /// <summary>
        /// 5.4.获取学科
        /// </summary>
        /// <returns></returns>
        [Route("subject.json")]
        [HttpGet]
        public IHttpActionResult subject(string source, string access_token, string schid,long specid,long gid)
        {
            if (!schoolbll.yz_gid(schid, specid, gid))
            {
                return Ok(new
                {
                    status = 0,
                    msg = "接口请求成功",
                    result = GetEMsg("050401")
                });
            }
            var list = schoolbll.getSubject(schid, specid, gid).Select(r => new
            { 
                id = r.SubjectID, 
                publicid =r.SUBID,
                subjectname = r.SubjectName
            }).ToArray();
            return Ok(new
            {
                status = 0,
                msg = "接口请求成功",
                result = new
                {
                    code = "0",
                    list = list,
                    total_number = list.Length
                }
            });
        }

        /// <summary>
        /// 5.5.获取章节
        /// </summary>
        /// <returns></returns>
        [Route("chapter.json")]
        [HttpGet]
        public IHttpActionResult chapter(string source, string access_token, 
            string schid,long specid,long gid,long sid,long pid=0)
        {
            if (!schoolbll.yz_sid(schid, specid, gid, sid))
            {
                return Ok(new
                {
                    status = 0,
                    msg = "接口请求成功",
                    result = GetEMsg("050501")
                });
            }
            var list = schoolbll.getSclass(schid, specid, gid, sid, pid).Select(r => new
            {
                id = r.SERID,
                sclassname = r.Sname
            }).ToArray();
            return Ok(new
            {
                status = 0,
                msg = "接口请求成功",
                result = new
                {
                    code = "0",
                    list = list,
                    total_number = list.Length
                }
            });
        }
    }
    
}
