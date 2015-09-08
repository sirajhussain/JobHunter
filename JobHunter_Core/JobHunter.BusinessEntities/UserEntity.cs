using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobHunter.BusinessEntities
{
    public class UserEntity
    {

        public int ID { get; set; }
        public int Role_ID { get; set; }
        public string Name { get; set; }
        public string User_Name { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public Nullable<int> Company_ID { get; set; }
        public Nullable<System.DateTime> Created_On { get; set; }
        public Nullable<System.DateTime> Modified_On { get; set; }
        public Nullable<bool> Is_Archived { get; set; }
        public string myTest { get; set; }

    }
}
