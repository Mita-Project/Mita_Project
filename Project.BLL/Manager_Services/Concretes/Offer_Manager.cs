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
    public class Offer_Manager:Base_Manager<Offer>,IOffer_Manager
    {
        IOffer_Repository _repository;
        public Offer_Manager(IOffer_Repository repository):base(repository) 
        {
            _repository = repository;
        }
    }
}
