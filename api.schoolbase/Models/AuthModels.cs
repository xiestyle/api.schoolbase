using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using api.schoolbase.Filters;

namespace api.schoolbase.Models
{

    public class LoginModel : BaseModel
    {
        [Required]
        public string vid { get; set; }
        [Required]
        public string os { get; set; }
        [Required]
        public string userid { get; set; }
        [Required]
        public string password { get; set; }
        public int difftype { get; set; }
    }
}