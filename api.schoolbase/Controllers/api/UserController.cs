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
    [RoutePrefix("user")]
    [Auth]
    public class UserController : ApiControllerBase
    {

        /// <summary>
        /// 获取个人信息
        /// </summary>
        /// <returns></returns>
        [Route("show.json")]
        [HttpGet]
        public IHttpActionResult show(string source, string access_token)
        {
            var userobj = user.getUserByToken(access_token);
            if (userobj == null) {
                return Ok(new {
                    status = 0,
                    msg = "接口请求成功",
                    result =GetEMsg("040101")
                });
            }
            return Ok(new
            {
                status = 0,
                msg = "接口请求成功",
                result = new
                {
                    code = "0",
                    username = userobj.name,
                    nickname = userobj.nickname,
                    headpic = Tools.FilePath(userobj.headpic),
                    sex = userobj.sex,
                    tel = userobj.tel,
                    school = userobj.schname,//new {schid=userobj.schid, schname=userobj.schname },
                    bdate = userobj.bdate.ToString("yyyy-MM-dd HH:mm:ss"),
                    sign = userobj.sign
                }
            });
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <returns></returns>
        [Route("chanage_password.json")]
        [HttpPost]
        public IHttpActionResult chanage_password(chanage_passwordModel model)
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

            bool isoldpw = user.isOldPwd((int)userobj.uid, model.old_password);
            if (!isoldpw)
            {
                return Ok(new
                {
                    status = 0,
                    msg = "接口请求成功",
                    result = GetEMsg("040201")
                });
            }
            if (model.old_password == model.new_password)
            {
                return Ok(new
                {
                    status = 0,
                    msg = "接口请求成功",
                    result = GetEMsg("040202")
                });
            }

            bool f = user.changePwd((int)userobj.uid, model.new_password);
            return Ok(new
            {
                status = 0,
                msg = "接口请求成功",
                result = f ? new {code="0" } : GetEMsg("040203")
            });
        }

        /// <summary>
        /// 修改头像
        /// </summary>
        /// <returns></returns>
        [Route("modify_head.json")]
        [HttpPost]
        public HttpResponseMessage modify_head()
        {
            HttpRequest request = HttpContext.Current.Request;
            HttpPostedFile file = HttpContext.Current.Request.Files["filedata"];
            string access_token = request.Params["access_token"];
            var userobj = user.getUserByToken(access_token); 
            if (file == null)//request.Params["filedata"] == null ||
            {
                return Request.CreateResponse(HttpStatusCode.OK, new
                {
                    status = 0,
                    msg = "接口请求成功",
                    result = GetEMsg("010001")
                });
            }
            Regex r = new Regex(@"(.jpg|.jpeg|.png|.gif)$");
            if (!r.IsMatch(file.FileName)) {
                return Request.CreateResponse(HttpStatusCode.OK, new
                {
                    status = 0,
                    msg = "接口请求成功",
                    result = GetEMsg("040301")
                });
            }
            if (file.ContentLength > 5242880)
            {
                return Request.CreateResponse(HttpStatusCode.OK, new
                {
                    status = 0,
                    msg = "接口请求成功",
                    result = GetEMsg("040302")
                });
            }
            byte[] buffer = new byte[file.ContentLength];
            Stream fs = file.InputStream;
            fs.Read(buffer, 0, file.ContentLength);
            string filetype =file.FileName.Substring(file.FileName.LastIndexOf('.'));
            int i = 0;
            try
            {
                SchoolBaseServer.SchoolBaseSoapClient client = new SchoolBaseServer.SchoolBaseSoapClient();
                i = client.UserModifyHead(access_token, filetype, buffer);
                //SkyDriveService.SkyDriveServiceSoapClient client = new SkyDriveService.SkyDriveServiceSoapClient();
                //i = client.UploadZipFile(userobj.userid, buffer, filename, file.FileName.Substring(file.FileName.LastIndexOf('.')), did);
            }
            catch (Exception e)
            {
                
            }
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
                    code = i == 1 ? "0" : GetEMsg("040303"),
                    
                }
            });
        }

        /// <summary>
        /// 修改个人信息
        /// </summary>
        /// <returns></returns>
        [Route("modify.json")]
        [HttpPost]
        public IHttpActionResult modify(modifyModel model) {
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
            bool f = user.modifyUser(userobj.uid, userobj.usertype,
                model.nickname,
                model.sex,
                model.tel,
                model.bdate,
                model.sign);
            return Ok(new
            {
                status = 0,
                msg = "接口请求成功",
                result = f ? new { code = "0" } : GetEMsg("040401")
            });
        }
    }
    
}
