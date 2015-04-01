using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using api.schoolbase.entities.DBBase;

namespace api.schoolbase.bll
{
    public class version
    {
        /// <summary>
        /// 是否是最新版本
        /// </summary>
        /// <param name="appid">应用id</param> 
        /// <param name="os">操作系统</param>
        /// <param name="vcode">版本号 如1.1.1</param>
        /// <param name="last_version">最新版本信息</param>
        /// <returns>
        /// code 0：当前是最新版本
        ///      1：检测到新版本（必须更新）ref 最新版本信息
        ///      2：检测到新版本（可选更新）ref 最新版本信息
        ///      3：检测失败（应用或应用版本或被检测版本不存在）
        /// </returns>
        public static KeyValuePair<int,string> isLatestVersion(string appid,string os,string vcode,out app_version last_version,out WxApplication wxapp) {
            int code = 0;
            string message = "当前是最新版本";
            last_version = new app_version();
            wxapp = new WxApplication();
            //被检测的版本
            var dvobj = _DBBase.app_version.Select()
                .Where(_DBBase.app_version.appid == appid
                && _DBBase.app_version.os == os
                && _DBBase.app_version.vcode == vcode)
                .ToSingleObject<app_version>();
            //最新版本
            var vobj = _DBBase.app_version.Select()
                .Where(_DBBase.app_version.appid == appid
                && _DBBase.app_version.os == os)
                .OrderBy(_DBBase.app_version.dtime.Desc)
                .Top(1).ToSingleObject<app_version>();
            if (vobj != null && dvobj != null)
            {
                var appobj = _DBBase.WxApplication.Select()
                    .Where(_DBBase.WxApplication.appid == appid)
                    .ToSingleObject<WxApplication>();
                if (appobj == null)
                {
                    code = 3;//检测失败
                    message = "检测失败[应用不存在]";
                }
                else
                {
                    if (vobj.vcode != vcode)
                    {
                        if (appobj.vsupport > dvobj.id && appobj.vsupport != 0)
                        {
                            code = 2;//可选更新
                            message = "检测到新版本[必须更新]";
                        }
                        else
                        {
                            code = 1;//必须更新
                            message = "检测到新版本[可选更新]";
                        }
                    }
                    last_version = vobj;
                    wxapp = appobj;
                }
            }
            else {
                code = 3;
                message = "检测失败[被检测的版本或最新版本不存在]";
            }
            return new KeyValuePair<int, string>(code,message);
        }

    }
}
