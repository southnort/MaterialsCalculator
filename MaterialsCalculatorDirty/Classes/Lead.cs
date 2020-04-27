using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialsCalculatorDirty.Classes
{
    class Lead
    {
        public int id { get; set; }
        public string name { get; set; }
        public int created_by { get; set; }
        public int created_at { get; set; }
        public int updated_at { get; set; }
        public int account_id { get; set; }
        public int pipeline_id { get; set; }
        public int status_id { get; set; }
        public bool is_deleted { get; set; }

        public Contact main_contact { get; set; }
        public List<Contact> contacts { get; set; }

        public int sale { get; set; }
        public int loss_reason_id { get; set; }   

    }
}
