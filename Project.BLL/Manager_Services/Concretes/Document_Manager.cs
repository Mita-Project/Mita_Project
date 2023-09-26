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
    public class Document_Manager:Base_Manager<Document>,IDocument_Manager
    {
        IDocument_Repository _repository;
        public Document_Manager(IDocument_Repository repository):base(repository)
        {
            _repository = repository;
        }
    }
}
