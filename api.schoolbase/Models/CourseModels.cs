using api.schoolbase.Filters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace api.schoolbase.Models
{
    public class courseAddModel : AuthModel
    {
        [Required]
        public long courseid { get; set; }
    }
}