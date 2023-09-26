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
    public class Material_Manager:Base_Manager<Material>,IMaterial_Manager
    {
        IMaterial_Repository _repository;
        public Material_Manager(IMaterial_Repository repository):base(repository) 
        {
            _repository = repository;
        }
    }
}
