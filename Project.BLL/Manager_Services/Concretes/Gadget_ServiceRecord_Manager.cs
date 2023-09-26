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
    public class Gadget_ServiceRecord_Manager:Base_Manager<Gadget_ServiceRecord>,IGadget_ServiceRecord_Manager
    {
        IGadget_ServiceRecord_Repository _repository;
        public Gadget_ServiceRecord_Manager(IGadget_ServiceRecord_Repository repository):base(repository) 
        {
            _repository = repository;
        }
    }
}
