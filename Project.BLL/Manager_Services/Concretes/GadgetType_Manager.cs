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
    public class GadgetType_Manager:Base_Manager<GadgetType>,IGadgetType_Manager
    {
        IGadgetType_Repository _repository;
        public GadgetType_Manager(IGadgetType_Repository repository):base(repository)
        {
            _repository = repository;
        }
    }
}
