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
    public class Company_Manager:Base_Manager<Company>,ICompany_Manager
    {
        ICompany_Repository _repository;
        public Company_Manager(ICompany_Repository repository):base(repository)
        {
            _repository = repository;
        }
        
    }
}
