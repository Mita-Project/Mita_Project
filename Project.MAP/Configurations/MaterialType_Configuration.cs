using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Configurations
{
    public class MaterialType_Configuration : BaseConfiguration<MaterialType>
    {
        public override void Configure(EntityTypeBuilder<MaterialType> builder)
        {
            base.Configure(builder);

            builder.HasMany(x => x.Materials)
                .WithOne(x => x.MaterialType);
        }
    }
}
