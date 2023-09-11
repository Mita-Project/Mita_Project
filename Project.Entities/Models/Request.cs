using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.Models
{
    public class Request:BaseEntity
    {
        public virtual List<Photograph> Photographs { get; set; }

        public string RequestTopic { get; set; }
        public string RequestDescription { get; set; }

        //Relations
        public virtual Company Company { get; set; }
        public int CompanyId { get; set; }

        
        public virtual ServiceRecord ServiceRecord { get; set; }
        public int ServiceRecordId { get; set; }

        public virtual Team Team { get; set; }
        public int TeamId { get; set; }

    }
}
