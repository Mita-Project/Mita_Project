using Project.BLL.Manager_Services.Abstracts;
using Project.DAL.Repositories.Abstracts;
using Project.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.Manager_Services.Concretes
{
    public class MaintenanceRecord_Manager:Base_Manager<MaintenanceRecord>,IMaintenanceRecord_Manager
    {
        IMaintenanceRecord_Repository _repository;
        public MaintenanceRecord_Manager(IMaintenanceRecord_Repository repository):base(repository) 
        {
            _repository = repository;
        }
    }
}
