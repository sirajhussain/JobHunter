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
    
    public partial class Token
    {
        public int ID { get; set; }
        public Nullable<int> User_ID { get; set; }
        public string AuthToken { get; set; }
        public Nullable<System.DateTime> Issued_On { get; set; }
        public Nullable<System.DateTime> Expires_On { get; set; }
    
        public virtual User User { get; set; }
    }
}
