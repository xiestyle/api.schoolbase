using api.schoolbase.bll;
using api.schoolbase.Filters;
using api.schoolbase.Models;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;

namespace api.schoolbase.Controllers
{
    [RoutePrefix("auth")]
    public class AuthController : ApiControllerBase
    {

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="source"></param>
        /// <param name="vid"></param>
        /// <param name="os"></param>
        /// <param name="userid"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        [Route("login.json")]
        [HttpPost]
        public HttpResponseMessage login(LoginModel model)
        {
            if (!ModelState.IsValid || model == null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, new
                {
                    status = 0,
                    msg = "接口请求成功",
                    result = GetEMsg("010001")//new { code = 2, message = "登录失败[表单验证失败]" }
                });
            }
            else{
                var obj = auth.Auth(model.userid, model.password);
                if (obj == null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new
                    {
                        status = 0,
                        msg = "接口请求成功",
                        result = GetEMsg("030101")//new { code = 1, message = "用户名或密码错误" }
                    });
                }
                var objex = auth.getUser_ex(obj.user_id);
                string token = auth.GetToken((long)obj.user_id, model.difftype,model.vid);
                //if (token == "")
                //{
                //    return Request.CreateResponse(HttpStatusCode.OK, new
                //    {
                //        status = 4,
                //        msg = "服务器异常",
                        
                //        result = new { code = 2, message = "登录失败[用户token获取失败]" }
                //    });
                //}
                var resp = Request.CreateResponse(HttpStatusCode.OK, new
                {
                    status = 0,
                    msg = "接口请求成功",
                    result = new
                    {
                        code = "0",
                        uid = obj.user_id,
                        username = obj.fullname,
                        schid = objex.DepID,
                        access_token = token
                    }
                });
                return resp;
            }
        }

        /// <summary>
        /// Token续期
        /// </summary>
        /// <param name="source"></param>
        /// <param name="access_token"></param>
        /// <returns></returns>
        [Auth]
        [Route("updatetoken.json")]
        [HttpPost]
        public IHttpActionResult updatetoken(AuthModel model)
        {
            bool f = auth.UpdateTokenTimestamp(model.access_token);
            return Ok(new
            {
                status = 0,
                msg = "接口请求成功",
                result = f?new{code = "0"}:GetEMsg("030201")
            });
        }


        /// <summary>
        /// 查看Token信息
        /// </summary>
        /// <param name="source"></param>
        /// <param name="access_token"></param>
        /// <returns></returns>
        [Auth]
        [Route("token/show.json")]
        [HttpGet]
        public IHttpActionResult token_show(string source, string access_token)
        {
            var token = auth.isExistsToken(access_token);
            long nowts = auth.DateToTimeStamp(DateTime.Now);
            long ts = token.timestamp;
            long df = token.timediff;
            string yxq = "30分钟";
            long lasts =ts+1800-nowts;
            switch (df)
            {
                case 1:
                    yxq = "7天";
                    lasts = ts + 604800 - nowts;
                    break;
                case 2:
                    yxq = "30天";
                    lasts = ts + 2592000 - nowts;
                    break;
            }
            TimeSpan d = new TimeSpan(0,0,(int)lasts);
            return Ok(new
            {
                status = 0,
                msg = "接口请求成功",
                result = new
                {
                    l1 = "token有效期：" + yxq,
                    l2 = "token有效剩余时间：" + (d.Days > 0 ? d.Days + "天" : "") + (d.Hours > 0 ? d.Hours + "小时" : "") + (d.Minutes > 0 ? d.Minutes + "分钟" : "")+d.Seconds+"秒",
                    l3 = "lasts:"+lasts,
                    l4 = "vid:"+token.vid
                }
            });
        }

        /// <summary>
        /// 注销
        /// </summary>
        /// <param name="source"></param>
        /// <param name="access_token"></param>
        /// <returns></returns>
        [Auth]
        [Route("logout.json")]
        [HttpPost]
        public IHttpActionResult logout(AuthModel model)
        {
            bool f = auth.setTokenStauts(model.access_token, 1);
            return Ok( new
                {
                    status = 0,
                    msg = "接口请求成功",
                    result = f ? new { code = "0" } : GetEMsg("030301")
                });
        }
    }
}
