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
    public class EMail_Manager:Base_Manager<EMail>,IEMail_Manager
    {
        IEMail_Repository _repository;
        public EMail_Manager(IEMail_Repository repository):base(repository) 
        {
            _repository = repository;
        }
    }
}
