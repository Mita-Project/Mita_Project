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
    public class Offer_Repository:BaseRepository<Offer>,IOffer_Repository
    {
        public Offer_Repository(MyContext db) : base(db)
        {
            
        }
    }
}
