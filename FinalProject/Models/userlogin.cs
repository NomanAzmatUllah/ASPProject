using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FinalProject.Models
{
    public class userlogin
    {
        public int reg_id { get; set; }

        [Required(ErrorMessage = "Please fill It")]

        [Display(Name = "Email")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")]
        public string user_email { get; set; }

        [Required(ErrorMessage = "Please fill It")]
        [Display(Name = "Cnic")]
        [RegularExpression(@"^\(([0-9]{5})[-]([0-9]{7})[-][0-9]{1}\)$")]
        public string user_cnic { get; set; }

    }
}