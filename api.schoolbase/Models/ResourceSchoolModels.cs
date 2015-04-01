using api.schoolbase.Filters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace api.schoolbase.Models
{
    public class CollectModel : AuthModel
    {
        [Required]
        public long rid { get; set; }
    }
    public class resourceCommentModel : AuthModel
    {
        [Required]
        public long rid { get; set; }

        [Required]
        [MinLength(10)]
        [MaxLength(500)]
        public string content { get; set; }

        [Required]
        [Range(1,5)]
        public int score { get; set; }
    }
    
}