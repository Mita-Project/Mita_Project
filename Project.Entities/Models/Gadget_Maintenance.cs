using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.Models
{
    public class Gadget_Maintenance:BaseEntity
    {
        public virtual Gadget Gadget { get; set; }
        public virtual Maintenance Maintenance { get; set; }
    }
}
