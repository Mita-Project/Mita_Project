using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.Models
{
    public class MaintenanceRecord_Material:BaseEntity
    {
        public virtual MaintenanceRecord MaintenanceRecord { get; set; }
        public int MaintenanceRecordId { get; set; }

        public virtual Material Material { get; set; }
        public int MaterialId { get; set; }
    }
}
