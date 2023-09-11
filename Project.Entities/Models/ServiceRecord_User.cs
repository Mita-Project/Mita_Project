using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.Models
{
    public class ServiceRecord_User:BaseEntity
    {
        public virtual ServiceRecord ServiceRecord { get; set; }
        public int ServiceRecordId { get; set; }

        public virtual User User { get; set; }
        public int UserId { get; set; }
    }
}
