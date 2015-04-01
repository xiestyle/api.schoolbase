using api.schoolbase.bll;
using System;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using System.Linq;
using System.Collections.Specialized;
using System.Diagnostics;

namespace api.schoolbase.Filters
{
    /// <summary>
    /// post form提交认证模型
    /// | 包含source、access_token属性
    /// </summary>
    public class AuthModel : BaseModel
    {
        public string access_token { get; set; }
    }
    /// <summary>
    /// 登录验证
    /// </summary>
    public class AuthAttribute : ActionFilterAttribute
    {
        /// <summary>
        /// 检查用户是否有该Action执行的操作权限
        /// </summary>
        /// <param name="actionContext"></param>
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            HttpRequest request = HttpContext.Current.Request;
            string token = null;
            if (request.Params["access_token"] != null)
            {
                token = request.Params["access_token"];
            }

            if (token == null)
            {
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.OK, new
                {
                    status = 1,
                    msg = "缺少参数[access_token]"
                });
                return;
            }
            else if ((token).Length < 32)
            {
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.OK, new
                {
                    status = 5,
                    msg = "用户安全性验证失败[无效的access_token]"
                });
                return;
            }
            
            
            var tokenobj = auth.isExistsToken(token);
            if (tokenobj == null)
            {
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.OK, new
                {
                    status = 5,
                    msg = "用户安全性验证失败[无效的access_token]"
                });
                return;
            }
            if (tokenobj.stauts != 0 || !auth.isValidToken(tokenobj))
            {//过期 设置状态
                auth.setTokenStauts(token, 1);
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.OK, new
                {
                    status = 5,
                    msg = "用户安全性验证失败[access_token已过期]"
                });
                return;
            }
            
            base.OnActionExecuting(actionContext);
        }
        
    }
}
