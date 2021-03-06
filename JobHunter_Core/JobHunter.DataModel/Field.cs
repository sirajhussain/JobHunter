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
    
    public partial class Field
    {
        public Field()
        {
            this.Sub_Field = new HashSet<Sub_Field>();
            this.Tags = new HashSet<Tag>();
        }
    
        public int ID { get; set; }
        public string Field_Name { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> Created_On { get; set; }
        public Nullable<System.DateTime> Modified_On { get; set; }
        public Nullable<bool> Is_Archived { get; set; }
    
        public virtual ICollection<Sub_Field> Sub_Field { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
    }
}
