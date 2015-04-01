using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace api.schoolbase.bll
{
    public class Tools
    {
        public static string FilePath(string path)
        {
            string retstring = "";
            if (!string.IsNullOrEmpty(path)) { 
                string host = ConfigurationManager.AppSettings["WEBHost"];
                retstring = path.Replace("{#server_image#}", host + "uploadfiles/image")
                    .Replace("{#server_video#}", host + "uploadfiles/video")
                    .Replace("{#server_html#}", host + "uploadfiles/html")
                    .Replace("{#server_file#}", host + "uploadfiles/file");
            }
            return retstring;
        }

        /// <summary>
        /// 获取日期范围中有多少周
        /// </summary>
        /// <param name="dt1">开始日期</param>
        /// <param name="dt2">结束日期</param>
        /// <returns></returns>
        public static int getDatasWeed(DateTime dt1, DateTime dt2)
        {
            dt1 = DateTime.Parse(dt1.ToString("yyyy-MM-dd"));
            dt2 = DateTime.Parse(dt2.ToString("yyyy-MM-dd"));
            int _days = (dt2 - dt1).Days + 1;
            int _weeks = 1;
            int n = (int)dt1.DayOfWeek;
            int m = (int)dt2.DayOfWeek;
            if (_days <= 7 && n < m)
            {
            }
            else
            {
                _weeks = (_days - (7 - n + 1) - m) / 7 + 2;
            }
            return _weeks;
        }

        public static string course_LoopTypeName(long looptype) {
            switch (looptype)
            {
                case 1:
                    return "每学期";
                case 2:
                    return "每月";
                case 4:
                    return "每两周";
                case 8:
                    return "每周";
                case 16:
                    return "每两天";
                case 32:
                    return "每天";
                default:
                    return "类型未定义";
            }
        }
        public static string course_LoopItemName(long looptype, long value)
        {
            switch (looptype)
            {
                case 32:
                    return "每天";
                case 16:
                    if (value == 0) return "第一天";
                    return "第二天";
                case 4:
                    return string.Empty;
                case 2:
                    return GetItemMonthName(value);
                case 8:
                    return GetItemWeekName(value);
                default:
                    return "未定义值";
            }
        }

        public static string GetItemMonthName(long day)
        {
            switch (day)
            {
                case 1:
                    return "01号";
                case 2:
                    return "02号";
                case 3:
                    return "03号";
                case 4:
                    return "04号";
                case 5:
                    return "05号";
                case 6:
                    return "06号";
                case 7:
                    return "07号";
                case 8:
                    return "08号";
                case 9:
                    return "09号";
                case 10:
                    return "10号";
                case 11:
                    return "11号";
                case 12:
                    return "12号";
                case 13:
                    return "13号";
                case 14:
                    return "14号";
                case 15:
                    return "15号";
                case 16:
                    return "16号";
                case 17:
                    return "17号";
                case 18:
                    return "18号";
                case 19:
                    return "19号";
                case 20:
                    return "20号";
                case 21:
                    return "21号";
                case 22:
                    return "22号";
                case 23:
                    return "23号";
                case 24:
                    return "24号";
                case 25:
                    return "25号";
                case 26:
                    return "26号";
                case 27:
                    return "27号";
                case 28:
                    return "28号";
                case 29:
                    return "29号";
                case 30:
                    return "30号";
                case 31:
                    return "31号";
                default:
                    return "未定义值";
            }
        }
        public static string GetItemWeekName(long week)
        {
            switch (week)
            {
                case 1:
                    return "星期一";
                case 2:
                    return "星期二";
                case 3:
                    return "星期三";
                case 4:
                    return "星期四";
                case 5:
                    return "星期五";
                case 6:
                    return "星期六";
                case 7:
                    return "星期天";
                default:
                    return "未定义值";
            }
        }
    }
}
