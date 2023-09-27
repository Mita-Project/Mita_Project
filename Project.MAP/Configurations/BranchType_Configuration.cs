using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Configurations
{
    public class BranchType_Configuration : BaseConfiguration<BranchType>
    {
        public override void Configure(EntityTypeBuilder<BranchType> builder)
        {
            base.Configure(builder);

            builder.HasMany(x => x.Branches)
                    .WithOne(x=>x.BranchType);
        }
    }
}
