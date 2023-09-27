using Project.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.Models
{
    public class Offer:BaseEntity
    {
        public OfferStatus OfferStatus { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime ClosedDate { get; set; }

        //Relations
        public virtual User User { get; set; }
        public int UserId { get; set; }

        public virtual ServiceRecord ServiceRecord { get; set; }
        public int ServiceRecordId { get; set; }

        public virtual Request Request { get; set; }
        public int RequestId { get; set; }

        public virtual List<Offer_Company> Offer_Companies { get; set; }
    }
}
