using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.Models
{
    public class Request:BaseEntity
    {
        public string RequestTopic { get; set; }
        public string RequestDescription { get; set; }

        //Relations
        public virtual Company Company { get; set; }
        public virtual List<Photograph> Fotographs { get; set; }
        public virtual ServiceRecord ServiceRecord { get; set; }
        public virtual Team Team { get; set; }

    
    }
}
