using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialsCalculatorDirty.Classes
{
    class Contact
    {
        public int id { get; set; }
        public string name { get; set; }
        public int resposible_user_id { get; set; }
        public int created_by { get; set; }
        public int created_at { get; set; }
        public int updated_at { get; set; }
        public int account_id { get; set; }
        public int updated_by { get; set; }
        public int group_id { get; set; }

        public List<Lead> leads { get; set; }
        public int closest_task_at { get; set; }
            
        public DateTime creatingDate { get; set; }

    }

    class Contacts
    {
        public CEmbedded _embedded { get; set; }
    }

    class CEmbedded
    {
        public Contact[] items { get; set; }
    }
}
