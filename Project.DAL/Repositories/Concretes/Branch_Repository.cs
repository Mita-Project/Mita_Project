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
    public class Branch_Repository : BaseRepository<Branch> , IBranch_Repository
    {
        public Branch_Repository(MyContext db) : base(db) 
        {
            
        }
    }
}
