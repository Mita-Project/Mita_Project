using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.Models
{
    public class Company:BaseEntity
    {
        public string CompanyName { get; set; }
        public string Company_VKN { get; set; }
        public string Address { get; set; }
        public string CompanyTelNo { get; set; }
        public string ContactPersonName{ get; set; }
        public string ContactPersonTelNo { get; set; }
        public string ContactPersonMail { get; set; }
        public string CompanyMail { get; set; }
        public string CompanyLogoFilePath { get; set; }

        //Relations
        public virtual List<Request> Requests { get; set; }
        public virtual List<ServiceRecord_Company> ServiceRecord_Companies { get; set; }
        public virtual List<Maintenance> Maintenances { get; set; }
        public virtual List<Branch> Branches { get; set; }
    }
}
