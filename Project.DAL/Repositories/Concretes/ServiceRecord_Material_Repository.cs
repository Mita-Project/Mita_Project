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
    public class ServiceRecord_Material_Repository:BaseRepository<ServiceRecord_Material>,IServiceRecord_Material_Repository
    {
        public ServiceRecord_Material_Repository(MyContext db) : base(db)
        {
            
        }
    }
}
