using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.Models
{
    public class Branch : BaseEntity
    {
        public string Branch_Name { get; set; }
        public string Branch_Exp { get; set; }
        public string Branch_City { get; set; }
        public string Branch_District { get; set; }

        // Relations
        public virtual Company Company { get; set; }
        public int CompanyId { get; set; }

        public virtual Maintenance Maintenance { get; set; }
        public virtual int MaintenanceId { get; set; }

        public virtual BranchType BranchType { get; set; }
        public int BranchTypeId { get; set; }

        public virtual List<Request> Requests { get; set; }

    }
}
