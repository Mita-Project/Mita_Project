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
    public class Maintenance_Manager:Base_Manager<Maintenance>,IMaintenance_Manager
    {
        IMaintenance_Repository _repository;
        public Maintenance_Manager(IMaintenance_Repository repository):base(repository)
        {
            _repository = repository;
        }
    }
}
