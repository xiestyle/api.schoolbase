using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace api.schoolbase.bll.model
{
    public class collectModel {
        public int id { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string dtime { get; set; }
    }
    public class userModel
    {
        public long uid { get; set; }
        public string userid { get; set; }
        public long usertype { get; set; }
        public string name { get; set; }
        public string nickname { get; set; }
        public string headpic { get; set; }
        public int sex { get; set; }
        public string tel { get; set; }

        public string schid { get; set; }
        public string schname { get; set; }
        public DateTime bdate { get; set; }
        public string sign { get; set; }
    }
}
