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
    public class Role_Repository:BaseRepository<Role>,IRole_Repository
    {
        public Role_Repository(MyContext db) : base(db)
        {
            
        }
    }
}
