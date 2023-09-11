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
    public class Company_Repository:BaseRepository<Company>,ICompany_Repository
    {
        public Company_Repository(MyContext db): base(db) 
        {

        }
    }
}
