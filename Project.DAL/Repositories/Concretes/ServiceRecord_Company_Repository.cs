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
    public class ServiceRecord_Company_Repository:BaseRepository<ServiceRecord_Company>,IServiceRecord_Company_Repository
    {
        public ServiceRecord_Company_Repository(MyContext db) : base(db)
        {
            
        }
    }
}
