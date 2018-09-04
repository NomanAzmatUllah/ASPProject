using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FinalProject.Models
{
    public class registerviewmodel
    {
        public int reg_id { get; set; }
        [Required(ErrorMessage = "Please fill It")]
        [Display(Name = "User-Name")]
        [MinLength(3)]
        [RegularExpression("@ ^[a - zA - Z] + $")]
        public string users_name { get; set; }
        [Required(ErrorMessage = "Please fill It")]
        [Display(Name = "Father-Name")]
        

        public string user_f_name { get; set; }

        [Required(ErrorMessage = "Please fill It")]
        [Display(Name = "Email")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")]

        public string user_email { get; set; }

        [Required(ErrorMessage = "Please fill It")]
        [Display(Name = "Cnic")]
        [RegularExpression(@"^\(([0-9]{5})[-]([0-9]{7})[-][0-9]{1}\)$")]
        public string user_cnic { get; set; }

        [Required(ErrorMessage = "Please fill It")]
        [Display(Name = "Registration-Date")]
        [DataType(DataType.Date)]

        public string user_reg_date { get; set; }

        [Required(ErrorMessage = "Please fill It")]
        [Display(Name = "Phonenumber")]

        public string user_phonenum { get; set; }

        [Required(ErrorMessage = "Please fill It")]
        [Display(Name = "Gender")]

        public string gender { get; set; }

        [Required(ErrorMessage = "Please fill It")]
        [Display(Name = "Address")]

        public string user_address { get; set; }

        [Required(ErrorMessage = "Please fill It")]
        [Display(Name = "Hec-Percentage")]

        public string user_hecPercentage { get; set; }
        [Required(ErrorMessage = "Please fill It")]
        [Display(Name = "Year Of Passing")]

        public string yearofpassingexam { get; set; }
        [Required(ErrorMessage = "Please fill It")]
        [Display(Name = "Depatment Apply")]

        public string dep_name { get; set; }

        [Required(ErrorMessage = "Please fill It")]
        [Display(Name = "Second Periority")]
        public string dep_name1 { get; set; }

        [Required(ErrorMessage = "Please fill It")]
        public Nullable<int> userdep_id { get; set; }

        [Required(ErrorMessage = "Please fill It")]
        public Nullable<int> userdep_id1 { get; set; }
        public Nullable<int> user_status { get; set; }


    }
}