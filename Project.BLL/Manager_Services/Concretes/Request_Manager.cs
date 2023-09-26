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
    public class Request_Manager:Base_Manager<Request>,IRequest_Manager
    {
        IRequest_Repository _repository;
        public Request_Manager(IRequest_Repository repository):base(repository) 
        {
            _repository = repository;
        }
    }
}
