using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.Models
{
    public class Material:BaseEntity
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }

        //Relations
        public virtual MaterialType MaterialType { get; set; }
        public int MaterialTypeId { get; set; }

        public virtual List<MaintenanceRecord_Material> MaintenanceRecord_Materials { get; set; }
        public virtual List<ServiceRecord_Material> ServiceRecord_Materials { get; set; }
    }
}
