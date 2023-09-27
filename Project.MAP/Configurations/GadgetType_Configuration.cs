using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Configurations
{
    public class GadgetType_Configuration : BaseConfiguration<GadgetType>
    {
        public override void Configure(EntityTypeBuilder<GadgetType> builder)
        {
            base.Configure(builder);

            builder.HasMany(x => x.Gadgets)
                .WithOne(x => x.GadgetType);
        }
    }
}
