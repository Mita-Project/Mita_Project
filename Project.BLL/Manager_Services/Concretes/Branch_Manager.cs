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
    public class Branch_Manager:Base_Manager<Branch>,IBranch_Manager
    {
        IBranch_Repository _repository;
        public Branch_Manager(IBranch_Repository repository):base(repository)
        {
            _repository = repository;
        }
    }
}
