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
    public class Gadget_ServiceRecord_Repository:BaseRepository<Gadget_ServiceRecord>,IGadget_ServiceRecord_Repository
    {
        public Gadget_ServiceRecord_Repository(MyContext db):base(db)
        {
            
        }
    }
}
