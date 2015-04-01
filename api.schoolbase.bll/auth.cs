using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using api.schoolbase.entities.DBUser;
using api.schoolbase.entities.DBBase;

namespace api.schoolbase.bll
{
    public class auth
    {
        public static WxAppKey VAppkey(string source)
        {
            return _DBBase.WxAppKey.Select()
                .Where(_DBBase.WxAppKey.akid == source)
                .ToSingleObject<WxAppKey>();
        }

        public static bool updateAppkeyStatus(string source, int status)
        {
            return _DBBase.WxAppKey.Update
                .AddColumn(_DBBase.WxAppKey.state, status)
                .Where(_DBBase.WxAppKey.akid == source)
                .Execute() > 0;
        }


        //验证登陆
        public static tUser Auth(string username, string pwd)
        {
            return _DBUser.tUser.Select()
                .Where(_DBUser.tUser.email == username && _DBUser.tUser.pwd.ToLower() == pwd.ToLower())
                .ToSingleObject<tUser>();
        }

        public static tUser_ex getUser_ex(long userid)
        {
            return _DBBase.tUser_ex.Select()
                .Where(_DBBase.tUser_ex.UID == userid)
                .ToSingleObject<tUser_ex>();
        }

        /// <summary>
        /// 登录后创建或更新token
        /// </summary>
        /// <param name="uid">用户id</param>
        /// <param name="difftype">
        /// 过期类型
        /// 0：不设置
        /// 1：7天后过期
        /// 2：30天后过期
        /// </param>
        /// <returns></returns>
        public static string GetToken(long uid, int difftype,string vid)
        {
            string ret_token = "";
            var obj = _DBBase.WxToken.Select().Where(_DBBase.WxToken.userid == uid).ToSingleObject<WxToken>();
            long diff = 0;
            switch (difftype)
            {
                case 1:
                    diff = 1;
                    break;
                case 2:
                    diff = 2;
                    break;
            }
            string token_guid = Guid.NewGuid().ToString();
            if (obj == null)//第一次
            {
                _DBBase.WxToken.Insert
                    .Set(new WxToken
                    {
                        userid = uid,
                        token = token_guid,
                        loginnum = 1,
                        lastlogintime = new DateTime(1970, 1, 1),
                        logintime = DateTime.Now,
                        timestamp = DateToTimeStamp(DateTime.Now),
                        timediff = diff,
                        stauts = 0,
                        vid = vid
                    })
                    .Execute();
                ret_token = token_guid;
            }
            else
            {
                if (obj.stauts == 0 && obj.vid == vid && isValidToken(obj))
                {
                   
                    ret_token = obj.token;
                }
                else
                {
                    _DBBase.WxToken.Update
                            .AddColumn(_DBBase.WxToken.token, token_guid)
                            .AddColumn(_DBBase.WxToken.loginnum, obj.loginnum + 1)
                            .AddColumn(_DBBase.WxToken.lastlogintime, obj.logintime)
                            .AddColumn(_DBBase.WxToken.logintime, DateTime.Now)
                            .AddColumn(_DBBase.WxToken.timestamp, DateToTimeStamp(DateTime.Now))
                            .AddColumn(_DBBase.WxToken.timediff, diff)
                            .AddColumn(_DBBase.WxToken.stauts, 0)
                            .AddColumn(_DBBase.WxToken.vid, vid)
                            .Where(_DBBase.WxToken.userid == obj.userid)
                            .Execute();
                    ret_token = token_guid;
                }
            }
            return ret_token;
        }
        public static bool setTokenStauts(string token, int stauts)
        {
            return _DBBase.WxToken.Update
                            .AddColumn(_DBBase.WxToken.stauts, stauts)
                            .Where(_DBBase.WxToken.token == token)
                            .Execute() > 0;
        }

        public static bool UpdateTokenTimestamp(string token)
        {
            return _DBBase.WxToken.Update
                            .AddColumn(_DBBase.WxToken.timestamp, DateToTimeStamp(DateTime.Now))
                            .Where(_DBBase.WxToken.token == token)
                            .Execute() > 0;
        }

        public static WxToken isExistsToken(string token)
        {
            return _DBBase.WxToken.Select()
                .Where(_DBBase.WxToken.token == token)
                .ToSingleObject<WxToken>();
        }

        /// <summary>
        /// 检测token是否在有效期
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public static bool isValidToken(WxToken token)
        {
            bool f = false;
            long timestamp = token.timestamp;
            long timediff = 0;//token.timediff;
            switch (token.timediff)
            {
                case 1:
                    timediff = timestamp + 604800;
                    break;
                case 2:
                    timediff = timestamp + 2592000;
                    break;
            }

            long nowts = DateToTimeStamp(DateTime.Now);
            if (timediff == 0)
            {
                f = timestamp + 1800 > nowts;
            }
            else
            {
                if (timediff > nowts)
                {
                    f = true;
                }
                else
                {
                    f = timestamp + 1800 > nowts;
                }
            }
            return f;
        }

        

        //注销



        //删除token
        public bool delToken(string token, long uid)
        {
            return true;
        }

        public static long DateToTimeStamp(DateTime dt)
        {
            DateTime dtStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            DateTime dtNow = dt;
            TimeSpan toNow = dtNow.Subtract(dtStart);
            string timeStamp = toNow.Ticks.ToString();
            timeStamp = timeStamp.Substring(0, timeStamp.Length - 7);
            return long.Parse(timeStamp);
        }

        public static DateTime TimeStampToDate(string timeStamp)
        {
            DateTime dtStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            long lTime = long.Parse(timeStamp + "0000000");
            TimeSpan toNow1 = new TimeSpan(lTime);
            DateTime dtResult = dtStart.Add(toNow1);
            return dtResult;
        }
    }
}
