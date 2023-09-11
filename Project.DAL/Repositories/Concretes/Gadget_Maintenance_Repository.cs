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
    public class Gadget_Maintenance_Repository:BaseRepository<Gadget_Maintenance>,IGadget_Maintenance_Repository
    {
        public Gadget_Maintenance_Repository(MyContext db):base(db) { }
        
            
    }
}

