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
        public virtual Offer Offer { get; set; }
        public int OfferId { get; set; }

        public virtual Company Company { get; set; }
        public int CompanyId { get; set; }

        public virtual Branch Branch { get; set; }
        public int BranchId { get; set; }


        public virtual ServiceRecord ServiceRecord { get; set; }
        public int ServiceRecordId { get; set; }

        public virtual Team Team { get; set; }
        public int TeamId { get; set; }

        public virtual List<Document> Documents { get; set; }
        public virtual List<Photograph> Photographs { get; set; }

    }
}
