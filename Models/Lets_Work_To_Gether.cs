//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Work_Code.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Lets_Work_To_Gether
    {
        public int id { get; set; }
        public string P_Name { get; set; }
        public string P_Desciption { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "date")]
        public Nullable<System.DateTime> Ex_Delivery_Date { get; set; }
        public string P_Budget { get; set; }
        public string Your_Name { get; set; }
        public string Your_mail { get; set; }
        public string Your_Phone { get; set; }
        public string Your_Address { get; set; }
        public string Uplode_Requirment_pdf { get; set; }
    }
}