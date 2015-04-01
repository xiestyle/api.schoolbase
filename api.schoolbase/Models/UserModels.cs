using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using api.schoolbase.Filters;

namespace api.schoolbase.Models
{

    public class collect_destroyModel : AuthModel
    {
        [Required]
        public int mcid { get; set; }
    }

    public class chanage_passwordModel : AuthModel
    {
        [Required]
        public string old_password { get; set; }
        [Required]
        public string new_password { get; set; }
    }

    public class modifyModel : AuthModel {
        public string nickname { get; set; }
        [Required]
        public int sex { get; set; }
        public string tel { get; set; }
        public string bdate { get; set; }
        public string sign { get; set; }
    }
    
}