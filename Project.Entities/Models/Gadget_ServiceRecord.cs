using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.Models
{
    public class Gadget_ServiceRecord:BaseEntity
    {
        public virtual ServiceRecord ServiceRecord { get; set; }
        public int ServiceRecordId { get; set; }

        public virtual Gadget Gadget { get; set; }
        public int GadgetId { get; set; }
    }
}
