using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.Models
{
    public class Gadget:BaseEntity
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }
        public double KW_Power { get; set; }

        //Relations
        public virtual List<Gadget_ServiceRecord> Gadget_ServiceRecords { get; set; }
        public virtual List<Gadget_Maintenance> Gadget_Maintenances { get; set; }

        public virtual GadgetType GadgetType { get; set; }
        public int GadgetTypeId { get; set; }
    }
}
