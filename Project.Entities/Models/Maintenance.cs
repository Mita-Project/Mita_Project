using Project.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.Models
{
    public class Maintenance:BaseEntity
    {
        public string MaintenanceName { get; set; }
        public string MaintenanceDescription { get; set; }
        public int MaintenanceFrequency { get; set; }
        public MaintenanceStatus MaintenanceStatus { get; set; }

        //Relations

        public virtual Company Company { get; set; }
        public int CompanyId { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual int BranchId { get; set; }

        public virtual MaintenanceType MaintenanceType { get; set; }
        public int MaintenanceTypeId { get; set; }

        public virtual List<MaintenanceRecord> MaintenanceRecords { get; set; }
        public virtual List<Gadget_Maintenance> Gadget_Maintenances { get; set; }
    }
}
