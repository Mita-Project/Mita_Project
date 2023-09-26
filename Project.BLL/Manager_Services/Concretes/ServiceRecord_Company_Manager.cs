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
    public class ServiceRecord_Company_Manager:Base_Manager<ServiceRecord_Company>,IServiceRecord_Company_Manager
    {
        IServiceRecord_Company_Repository _repository;
        public ServiceRecord_Company_Manager(IServiceRecord_Company_Repository repository):base(repository) 
        {
            _repository = repository;
        }
    }
}
