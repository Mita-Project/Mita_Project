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
    public class Offer_Company_Manager:Base_Manager<Offer_Company>,IOffer_Company_Manager
    {
        IOffer_Company_Repository _repository;
        public Offer_Company_Manager(IOffer_Company_Repository repository):base(repository) 
        {
            _repository = repository;
        }
    }
}
