using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.Models
{
    public class Team:BaseEntity
    {
        public string TeamName{ get; set; }
        public string TeamDescription { get; set; }

        //Relations
        public virtual List<User> Users { get; set; }
        public virtual List<Request> Requests { get; set; }
        public virtual List<MaintenanceRecord> MaintenanceRecords { get; set; }
        public virtual List<ServiceRecord> ServiceRecords { get; set; }
    }
}
