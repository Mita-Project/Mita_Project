using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.Models
{
    public class BranchType : BaseEntity
    {
        public string Type_Name { get; set; }
        public string Type_Exp { get; set; }

        // Relations
        public virtual List<Branch> Branches { get; set; }
    }
}
