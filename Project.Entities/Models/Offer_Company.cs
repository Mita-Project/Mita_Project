using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.Models
{
    public class Offer_Company:BaseEntity
    {
        public virtual Offer Offer { get; set; }
        public int OfferId { get; set; }

        public virtual Company Company { get; set; }
        public int CompanyId { get; set; }
    }
}
