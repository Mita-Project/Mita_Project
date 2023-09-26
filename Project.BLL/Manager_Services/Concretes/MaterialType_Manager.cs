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
    public class MaterialType_Manager:Base_Manager<MaterialType>,IMaterialType_Manager
    {
        IMaterialType_Repository _repository;

        public MaterialType_Manager(IMaterialType_Repository repository):base(repository) 
        {
            _repository = repository;
        }
    }
}
