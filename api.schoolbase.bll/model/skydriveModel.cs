using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace api.schoolbase.bll.model
{
    public class skydriveModel
    {
        public string id { get; set; }
        public string name { get; set; }
        public long filesize { get; set; }
        public string dtime { get; set; }
        public int type { get; set; }

    }

    public class fileModel 
    {
        public string id { get; set; }
        public string title { get; set; }

        public string filetype { get; set; }
        public string des { get; set; }
        public long filesize { get; set; }
        public string dtime { get; set; }
        public string filepath { get; set; }
    }
}
