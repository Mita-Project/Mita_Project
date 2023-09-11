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
    public class MaintenanceRecord_Material_Repository:BaseRepository<MaintenanceRecord_Material>,IMaintenanceRecord_Material_Repository
    {
        public MaintenanceRecord_Material_Repository(MyContext db):base(db) 
        {
            
        }
    }
}
