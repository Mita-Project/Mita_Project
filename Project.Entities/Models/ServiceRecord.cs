using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.Models
{
    public class ServiceRecord:BaseEntity
    {
        public string RecordName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public string Topic { get; set; }
        public decimal Price { get; set; }
        public decimal SubcontractorPrice { get; set; }
        public bool Subcontractor_Exists { get; set; }

        //Relations
        public virtual Offer Offer { get; set; }
        public int OfferId { get; set; }

        public virtual Request Request { get; set; }
        public int RequestId { get; set; }

        public virtual Team Team { get; set; }
        public int TeamId { get; set; }

        public virtual List<EMail> EMail { get; set; }
        public virtual List<ServiceRecord_Material> ServiceRecord_Materials { get; set; }
        public virtual List<ServiceRecord_Company> ServiceRecord_Companies { get; set; }
        public virtual List<ServiceRecord_User> ServiceRecord_Users { get; set; }
        public virtual List<Message> Messages { get; set; }
        public virtual List<Photograph> Photographs { get; set; }
    }
}
