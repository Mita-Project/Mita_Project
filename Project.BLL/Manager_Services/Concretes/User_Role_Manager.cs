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
    public class User_Role_Manager : Base_Manager<User_Role>, IUser_Role_Manager
    {
        IUser_Role_Repository _repository;

        public User_Role_Manager(IUser_Role_Repository repository) : base(repository) 
        {
            _repository = repository;
        }
    }
}
