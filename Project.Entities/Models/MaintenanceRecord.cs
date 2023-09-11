using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.Models
{
    public class MaintenanceRecord:BaseEntity
    {
        public DateTime MaintenanceDate { get; set; }
        public decimal Price { get; set; }
        public bool Status { get; set; }

        //Relations
        public virtual Maintenance Maintenance { get; set; }
        public int MaintenanceId { get; set; }

        public virtual Team Team { get; set; }
        public int TeamId { get; set; }

        public virtual List<MaintenanceRecord_Material> MaintananceRecord_Materials { get; set; }
    }
}
