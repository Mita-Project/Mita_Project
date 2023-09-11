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
    public class Document_Repository:BaseRepository<Document>,IDocument_Repository
    {
        public Document_Repository(MyContext db) : base(db)
        {
            
        }
    }
}
