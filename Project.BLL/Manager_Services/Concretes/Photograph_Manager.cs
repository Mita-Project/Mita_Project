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
    public class Photograph_Manager:Base_Manager<Photograph>,IPhotograph_Manager
    {
        IPhotograph_Repository _repository;
        public Photograph_Manager(IPhotograph_Repository repository):base(repository) 
        {
            _repository = repository;
        }
    }
}
