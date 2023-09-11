using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.Models
{
    public class Message:BaseEntity
    {
        public string Writing { get; set; }
        public DateTime SentTime { get; set; }

        //Relations
        public virtual User User { get; set; }
        public virtual List<Document> Documents { get; set; }
        public virtual List<Photograph> Fotographs { get; set; }
        public virtual ServiceRecord ServiceRecord { get; set; }
    }
}
