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
    public class Team_Manager:Base_Manager<Team>,ITeam_Manager
    {
        ITeam_Repository _repository;
        public Team_Manager(ITeam_Repository repository):base(repository) 
        {
            _repository = repository;
        }
    }
}
