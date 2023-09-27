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
    public class User_Manager : Base_Manager<User>, IUser_Manager
    {
        IUser_Repository _repository;

        public User_Manager(IUser_Repository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
