using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.Models
{
    public class EMail:BaseEntity
    {
        public string Topic { get; set; }
        public string Message { get; set; }

        //Relations
        public virtual List<Document> Documents { get; set; }
        public virtual ServiceRecord ServiceRecord { get; set; }
        public int ServiceRecordId { get; set; }
    }
}
