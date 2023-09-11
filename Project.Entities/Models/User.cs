using Microsoft.AspNetCore.Identity;
using Project.Entities.Enums;
using Project.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.Models
{
    public class User : IdentityUser<int>, IEntity
    {

        public User()
        {
            CreatedDate = DateTime.Now;
            Status = DataStatus.Active;
        }
        //IEntity Properties
        public int ID { get ; set ; }
        public DateTime CreatedDate { get ; set ; }
        public DateTime UpdatedDate { get ; set ; }
        public DateTime DeletedDate { get ; set ; }
        public string? CreatedBy { get ; set ; }
        public string? UpdatedBy { get ; set ; }
        public string? DeletedBy { get ; set ; }
        public DataStatus Status { get ; set ; }

        //Custom Properties
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TelNo { get; set; }
        public string Address { get; set; }
        public string IBAN { get; set; }

        //Relations
        public virtual List<User_Role> User_Roles { get; set; }
        public virtual List<ServiceRecord_User> ServiceRecord_Users { get; set; }
        public virtual List<Offer> Offers { get; set; }
        public virtual List<Message> Messages { get; set; }

        public virtual Team Team { get; set; }
        public int TeamId { get; set; }


    }
}
