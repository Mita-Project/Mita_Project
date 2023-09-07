using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.Models
{
    public class Offer_Company:BaseEntity
    {
        public virtual List<Offer> Offers { get; set; }
        public virtual List<Company> Companies { get; set; }
    }
}
