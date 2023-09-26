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
    public class Message_Manager:Base_Manager<Message>,IMessage_Manager
    {
        IMessage_Repository _repository;
        public Message_Manager(IMessage_Repository repository):base(repository) 
        {
            _repository = repository;
        }
    }
}
