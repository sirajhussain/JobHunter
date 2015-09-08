using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobHunter.BusinessEntities
{
   public class TokenEntity
    {
        public int ID { get; set; }
        public Nullable<int> User_ID { get; set; }
        public string AuthToken { get; set; }
        public System.DateTime Issued_On { get; set; }
        public System.DateTime Expires_On { get; set; }
    }
}
