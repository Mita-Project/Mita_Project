using Project.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using Document = Project.Entities.Models.Document;

namespace Project.DAL.Repositories.Abstracts
{
    public interface IDocument_Repository:IRepository<Document>
    {
    }
}

//todo: Document anahtar kelimesi sistemde mevcut bu sebeple hangisinin kullanılıacağının belli etmek için using Document = Project.Entities.Models.Document; komutu kullanıldı. Bunun düzenlenmesi gerek sonradan bir sıkıntı çıkmamaı için.
