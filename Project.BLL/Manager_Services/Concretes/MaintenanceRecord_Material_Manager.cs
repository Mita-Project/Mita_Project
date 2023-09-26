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
    public class MaintenanceRecord_Material_Manager:Base_Manager<MaintenanceRecord_Material>,IMaintenanceRecord_Material_Manager
    {
        IMaintenanceRecord_Material_Repository _repository;
        public MaintenanceRecord_Material_Manager(IMaintenanceRecord_Material_Repository repository):base(repository) 
        {
            _repository = repository;
        }
    }
}
