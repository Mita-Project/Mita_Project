﻿using Project.BLL.Manager_Services.Abstracts;
using Project.DAL.Repositories.Abstracts;
using Project.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.Manager_Services.Concretes
{
    public class Role_Manager : Base_Manager<Role>, IRole_Manager
    {
        IRole_Repository _repository;

        public Role_Manager(IRole_Repository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
