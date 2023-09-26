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
    public class Gadget_Manager:Base_Manager<Gadget>,IGadget_Manager
    {
        IGadget_Repository _repository;
        public Gadget_Manager(IGadget_Repository repository):base(repository) 
        {
            _repository = repository;
        }
    }
}
