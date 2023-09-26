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
    public class MaintenanceType_Manager:Base_Manager<MaintenanceType>,IMaintenanceType_Manager
    {
        IMaintenanceType_Repository _repository;
        public MaintenanceType_Manager(IMaintenanceType_Repository repository):base(repository) 
        {
            _repository = repository;
        }
    }
}
