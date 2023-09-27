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
    public class ServiceRecord_User_Manager : Base_Manager<ServiceRecord_User>, IServiceRecord_User_Manager
    {
        IServiceRecord_User_Repository _repository;

        public ServiceRecord_User_Manager(IServiceRecord_User_Repository repository) : base(repository)
        {
            _repository = repository;   
        }
    }
}
