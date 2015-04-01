using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace api.schoolbase.Models
{
    public class App_version
    {
        public long id { get; set; }
        public string appid { get; set; }
        public string os { get; set; }
        public string vcode { get; set; }
        public int filesize { get; set; }
        public DateTime dtime { get; set; }
        public string appdesc { get; set; }
        public string fileurl { get; set; }
    }
}