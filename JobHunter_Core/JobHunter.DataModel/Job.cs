//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JobHunter.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Job
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Nullable<int> Job_Location_ID { get; set; }
        public Nullable<int> Job_Type_ID { get; set; }
        public int User_ID { get; set; }
        public Nullable<int> Company_ID { get; set; }
        public Nullable<int> Experience_Min { get; set; }
        public Nullable<int> Experience_Max { get; set; }
        public Nullable<int> Expiry_Date { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string SalaryRange { get; set; }
        public string Other { get; set; }
        public string Create_On { get; set; }
        public Nullable<System.DateTime> Modified_On { get; set; }
        public Nullable<bool> Is_Archived { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual Job_Location Job_Location { get; set; }
        public virtual Job_Type Job_Type { get; set; }
    }
}