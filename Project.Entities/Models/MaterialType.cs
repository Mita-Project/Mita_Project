using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.Models
{
    public class MaterialType:BaseEntity
    {
        public string TypeName { get; set; }
        public string TypeDescription { get; set; }

        //Relations
        public virtual List<Material> Materials { get; set; }
    }
}
