using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.Models
{
    public class Document:BaseEntity
    {
        public string FileName { get; set; }
        public string FilePath { get; set; }

        //Relations
        public virtual Message Message { get; set; }
        public int MessageId { get; set; }

        public virtual EMail EMail { get; set; }
        public int EMailId { get; set; }

        public virtual Request Request { get; set; }
        public int RequestId { get; set; }
    }
}
