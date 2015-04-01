using api.schoolbase.Filters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace api.schoolbase.Models
{
    public class directory_createModel : AuthModel
    {
        [Required]
        public string name { get; set; }
        
        public string did { get; set; }
    }

    public class directory_updateModel : AuthModel
    {
        [Required]
        public string name { get; set; }
        [Required]
        public string did { get; set; }
    }


    public class directory_destroyModel : AuthModel
    {
        
        [Required]
        public string did { get; set; }
    }

    public class file_uploadModel : AuthModel
    {

        [Required]
        public string filename { get; set; }

        public string did { get; set; }
    }

    public class file_renameModel : AuthModel
    {

        [Required]
        public string fid { get; set; }

        [Required]
        public string filename { get; set; }
    }

    public class file_destroyModel : AuthModel
    {

        [Required]
        [RegularExpression(@"^(\w+)(,\w+)*$")]
        public string fids { get; set; }
    }
  
}