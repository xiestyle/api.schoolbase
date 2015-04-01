using api.schoolbase.bll;
using api.schoolbase.Filters;
using api.schoolbase.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Xml.Linq;

namespace api.schoolbase.Controllers
{
    /// <summary>
    /// 9.配置中心
    /// </summary>
    [Auth]
    [RoutePrefix("config")]
    public class ConfigController : ApiControllerBase
    {
        /// <summary>
        /// 9.1.获取学校配置
        /// </summary>
        /// <returns></returns>
        [Route("school.json")]
        [HttpGet]
        public IHttpActionResult school(string source, string access_token,string schid)
        {
            var userobj = user.getUserByToken(access_token);
            var schoolobj = schoolbll.getSchoolById(schid);
            var schoolterm = schoolbll.getSchTerm(schid, schoolobj.SchYear, schoolobj.SchTerm);
            int schoolweeks = Tools.getDatasWeed(schoolterm.StartTime,schoolterm.EndTime);
            int nowweek = Tools.getDatasWeed(schoolterm.StartTime, DateTime.Now);
            return Ok(new
            {
                status = 0,
                msg = "接口请求成功",
                result = new
                {
                    code = "0",
                    schname = schoolobj.SchName,
                    schlogo = Tools.FilePath(schoolobj.SchLogo),
                    schurl = schoolobj.SchWeb,
                    current_term = new { 
                        startime = schoolterm .StartTime.ToString("yyyy-MM-dd"),
                        endtime = schoolterm.EndTime.ToString("yyyy-MM-dd")
                    },
                    current_totalweek = schoolweeks,
                    current_week = nowweek
                }
            });
        }

        /// <summary>
        /// 9.2.获取资源配置
        /// </summary>
        /// <returns></returns>
        [Route("resource.json")]
        [HttpGet]
        public IHttpActionResult resource(string source, string access_token, string schid)
        {
            var userobj = user.getUserByToken(access_token);
            var list = configbll.getSchoolCategory(schid).Select(r => new { 
                id=r.SERID,
                name = r.CategoryName
            }).ToArray();
            return Ok(new
            {
                status = 0,
                msg = "接口请求成功",
                result = new
                {
                    code = "0",
                    resource_class =list
                }
            });
        }

        /// <summary>
        /// 9.3.获取云盘配置
        /// </summary>
        /// <returns></returns>
        [Route("skydrive.json")]
        [HttpGet]
        public IHttpActionResult resource_show(string source, string access_token, string schid)
        {
            var userobj = user.getUserByToken(access_token);
            XElement root = XElement.Load(HttpContext.Current.Server.MapPath("~/xml/config.xml"));

            var query =
                from ele in root.Elements("skydrive")
                where ele.Attribute("schid").Value.ToString() == schid
                select ele;
            var item = query.SingleOrDefault();
            if (item != null)
            {

                return Ok(new
                {
                    status = 0,
                    msg = "接口请求成功",
                    result = new
                    {
                        code = "0",
                        filesize = item.Attribute("filesize").Value,
                        filetype = item.Element("filetype").Elements("item").Select(r => new
                        {
                            typegroup = r.Attribute("typegroup").Value.ToString(),
                            extension = r.Attribute("extension").Value.ToString()
                        })
                    }
                });
            }
            else {
                var query2 =
                from ele in root.Elements("skydrive")
                where ele.Attribute("schid").Value.ToString() == "public"
                select ele;
                var item2 = query2.SingleOrDefault();
                return Ok(new
                {
                    status = 0,
                    msg = "接口请求成功",
                    result = new
                    {
                        code = "0",
                        filesize = item2.Attribute("filesize").Value,
                        filetype = item2.Element("filetype").Elements("item").Select(r => new
                        {
                            typegroup = r.Attribute("typegroup").Value.ToString(),
                            extension = r.Attribute("extension").Value.ToString()
                        })
                    }
                });
            }

            
        }
    }
    
}
