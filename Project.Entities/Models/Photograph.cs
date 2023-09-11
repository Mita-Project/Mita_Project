using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.Models
{
    public class Photograph:BaseEntity
    {
        public string FilePath { get; set; }

        //Relations
        public virtual Request Request { get; set; }
        public int RequestId { get; set; }

        public virtual ServiceRecord ServiceRecord { get; set; }
        public int ServiceRecordId { get; set; }

        public virtual Message Message { get; set; }
        public int MessageId { get; set; }
    }
}
