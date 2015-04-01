using api.schoolbase.entities.DBZiyuan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace api.schoolbase.bll
{
    public class configbll
    {
        public static List<ZYK_SchoolCategory> getSchoolCategory(string schid) {
            return _DBZiyuan.ZYK_SchoolCategory.Select()
                .Where(_DBZiyuan.ZYK_SchoolCategory.SchSerID == schid)
                .ToList<ZYK_SchoolCategory>();
        }
    }
}
