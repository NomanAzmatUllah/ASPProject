using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FinalProject.Models
{
    public class adminviewmodel
    {
        public int admin_id { get; set; }
        [Required(ErrorMessage ="Required")]
        public string admin_name { get; set; }
        [Required(ErrorMessage = "Required")]
        public string admin_email { get; set; }
        [Required(ErrorMessage = "Required")]
        [DataType(DataType.Password)]
        public string admin_password { get; set; }
        [Required(ErrorMessage = "Required")]
        [DataType(DataType.Password)]
        [Compare("admin_password")]
        public string admin_c_password { get; set; }
    }
}