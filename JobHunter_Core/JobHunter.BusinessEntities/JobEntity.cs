using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobHunter.BusinessEntities
{
    public class JobEntity
    {

        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Job_Location_ID { get; set; }
        public int Job_Type_ID { get; set; }
        public int User_ID { get; set; }
        public int Company_ID { get; set; }
        public int Experience_Min { get; set; }
        public int Experience_Max { get; set; }
        public Nullable<int> Expiry_Date { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string SalaryRange { get; set; }
        public string Other { get; set; }
        public string Create_On { get; set; }
        public System.DateTime Modified_On { get; set; }
        public bool Is_Archived { get; set; }

    }
}
