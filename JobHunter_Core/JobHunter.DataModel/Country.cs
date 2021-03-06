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
    
    public partial class Country
    {
        public Country()
        {
            this.Cities = new HashSet<City>();
            this.Companies = new HashSet<Company>();
            this.Job_Location = new HashSet<Job_Location>();
        }
    
        public int ID { get; set; }
        public string Country_Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    
        public virtual ICollection<City> Cities { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<Job_Location> Job_Location { get; set; }
    }
}
