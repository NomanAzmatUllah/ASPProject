//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class user_register
    {
        public int reg_id { get; set; }
        public string users_name { get; set; }
        public string user_f_name { get; set; }
        public string user_email { get; set; }
        public string user_cnic { get; set; }
        public string user_reg_date { get; set; }
        public string user_phonenum { get; set; }
        public string gender { get; set; }
        public string user_address { get; set; }
        public Nullable<int> user_status { get; set; }
        public string user_hecPercentage { get; set; }
        public string yearofpassingexam { get; set; }
        public Nullable<int> userdep_id { get; set; }
        public Nullable<int> userdep_id1 { get; set; }

        public string dep_name { get; set; }
        public string dep_name1 { get; set; }
        public virtual department department { get; set; }
        public virtual department1 department1 { get; set; }
    }
}
