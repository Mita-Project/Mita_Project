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
    public class User_Role_Repository:BaseRepository<User_Role>,IUser_Role_Repository
    {
        public User_Role_Repository(MyContext db) : base(db)
        {
            
        }
    }
}
