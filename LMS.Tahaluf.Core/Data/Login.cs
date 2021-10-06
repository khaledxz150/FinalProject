using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LMS.Tahaluf.Core.Data
{
   public class Login
    {[Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="username is required")]
        public string UserName  { get; set; }
        [Required]
        public string Password { get; set; }
        public string RoleName { get; set; }
       
        public virtual Teacher Teacher { get; set; }
    }
}
