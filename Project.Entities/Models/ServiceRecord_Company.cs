using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.Models
{
    public class ServiceRecord_Company:BaseEntity
    {
        public virtual ServiceRecord ServiceRecord { get; set; }
        public int ServiceRecordId { get; set; }

        public virtual Company Company { get; set; }
        public int CompanyId { get; set; }
    }
}
