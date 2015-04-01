using api.schoolbase.bll;
using api.schoolbase.Filters;
using api.schoolbase.Models;
using api.schoolbase.entities.DBBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace api.schoolbase.Controllers
{
    /// <summary>
    /// 2.版本
    /// </summary>
    [RoutePrefix("version")]
    public class VersionController : ApiControllerBase
    {
        /// <summary>
        /// 2.1. 版本检测
        /// </summary>
        /// <param name="source">应用密钥appkey</param>
        /// <param name="appid">应用id</param>
        /// <param name="vid">设备id</param>
        /// <param name="ostype">操作系统类别 （android\ios）</param>
        /// <param name="vcode">版本号 如1.1.1</param>
        /// <returns>
        /// {
        ///"status":0,
        ///"msg":"接口请求成功",
        ///"result":{
        ///    "code":1,
        ///    "message":"检测到新版本[可选更新]",
        ///    "appname":"示例应用",
        ///    "vcode":"1.1.1",
        ///    "filesize":5428012,
        ///    "dtime":"2014-09-30 15:47:55",
        ///    "desc":"<p>描述信息</p>",
        ///    "url":"下载地址"
        ///  }
        ///} 
        /// </returns>
        [Route("detection.json")]
        [HttpGet]
        public IHttpActionResult detection(string source, string appid, string vid, string ostype, string vcode)
        {
            app_version vobj;
            WxApplication appobj;
            
            var obj = version.isLatestVersion(appid,ostype,vcode,out vobj,out appobj);

            if (obj.Key == 3)
            {
                return Ok(new
                {
                    status = 0,
                    msg = "接口请求成功",
                    result = GetEMsg("020101")
                });
            }
            else{
                return Ok(new
                {
                    status = 0,
                    msg = "接口请求成功",
                    result = new
                    {
                        code = "0",
                        recode = obj.Key,
                        //message = obj.Value,
                        appname = appobj.appname,
                        vcode = vobj.vcode,
                        filesize = vobj.filesize,
                        dtime = vobj.dtime.ToString("yyyy-MM-dd HH:mm:ss"),
                        desc = vobj.appdesc,
                        url = Tools.FilePath(vobj.fileurl)
                    }
                });
            }
           
        }
    }
    
}
