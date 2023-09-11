using Project.DAL.Context;
using Project.DAL.Repositories.Abstracts;
using Project.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Repositories.Concretes
{
    public class Request_Repository:BaseRepository<Request>,IRequest_Repository
    {
        public Request_Repository(MyContext db) : base(db)
        {
            
        }
    }
}
