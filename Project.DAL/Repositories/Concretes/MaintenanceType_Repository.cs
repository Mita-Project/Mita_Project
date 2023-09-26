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
    public class MaintenanceType_Repository:BaseRepository<MaintenanceType>,IMaintenanceType_Repository
    {
        public MaintenanceType_Repository(MyContext db) : base(db)
        {
            
        }
    }
}
