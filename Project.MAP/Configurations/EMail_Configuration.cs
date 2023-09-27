using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Configurations
{
    public class EMail_Configuration : BaseConfiguration<EMail>
    {
        public override void Configure(EntityTypeBuilder<EMail> builder)
        {
            base.Configure(builder);

            builder.HasMany(x => x.Documents)
                .WithOne(x => x.EMail);
        }
    }
}
