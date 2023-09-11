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
    public class ServiceRecord_User_Repository:BaseRepository<ServiceRecord_User>,IServiceRecord_User_Repository
    {
        public ServiceRecord_User_Repository(MyContext db) : base(db)
        {
            
        }
    }
}
