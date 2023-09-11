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
    public class Photograph_Repository:BaseRepository<Photograph>,IPhotograph_Repository
    {
        public Photograph_Repository(MyContext db) : base(db)
        {
            
        }
    }
}
