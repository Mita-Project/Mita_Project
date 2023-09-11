using Project.DAL.Context;
using Project.DAL.Repositories.Abstracts;
using Project.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Repositories.Concretes
{
    public class Offer_Company_Repository:BaseRepository<Offer_Company>,IOffer_Company_Repository
    {
        public Offer_Company_Repository(MyContext db) : base(db)
        {
            
        }
    }
}
