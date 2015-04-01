using api.schoolbase.bll;
using System;
using System.Linq;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace api.schoolbase.Filters
{
    /// <summary>
    /// post form提交基本模型
    /// | 包含source属性
    /// </summary>
    public class BaseModel
    {
        public string source { get; set; }
    }
    /// <summary>
    /// 基本验证
    /// </summary>
    public class BaseAttribute : ActionFilterAttribute
    {
        /// <summary>
        /// 检查用户是否有该Action执行的操作权限
        /// </summary>
        /// <param name="actionContext"></param>
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            HttpRequest request = HttpContext.Current.Request;

            string source = null;
            if (request.Params["source"] != null)
            {
                source = request.Params["source"];
            }

            if (source == null)
            {
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.OK, new
                {
                    status = 1,
                    msg = "缺少参数[接口密钥]"
                });
                return;
            }
            else if ((source).Length < 32)
            {
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.OK, new
                {
                    status = 2,
                    msg = "接口密钥不正确"
                });
                return;
            }


            var akobj = auth.VAppkey(source.ToString());
            if (akobj == null)
            {
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.OK, new
                {
                    status = 2,
                    msg = "接口密钥不正确"
                });
                return;
            }
            if (akobj.state > 0 || akobj.exptime < DateTime.Now)
            {
                auth.updateAppkeyStatus(source.ToString(), 1);
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.OK, new
                {
                    status = 3,
                    msg = "接口服务过期"
                });
                return;
            }
            base.OnActionExecuting(actionContext);
        }
    }
}
