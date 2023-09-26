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
    public class BranchType_Manager:Base_Manager<BranchType>,IBranchType_Manager
    {
        IBranchType_Repository _repository;
        public BranchType_Manager(IBranchType_Repository repository) : base(repository)
        {
            _repository = repository;
        }
        
    }
}
