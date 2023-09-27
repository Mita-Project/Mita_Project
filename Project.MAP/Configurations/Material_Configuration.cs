using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Configurations
{
    public class Material_Configuration : BaseConfiguration<Material>
    {
        public override void Configure(EntityTypeBuilder<Material> builder)
        {
            base.Configure(builder);

            builder.HasOne(x => x.MaterialType)
                .WithMany(x => x.Materials)
                .HasForeignKey(x => x.MaterialTypeId)
                .IsRequired();

            builder.HasMany(x => x.MaintenanceRecord_Materials)
                .WithOne(x => x.Material);

            builder.HasMany(x => x.ServiceRecord_Materials)
                .WithOne(x => x.Material);
        }
    }
}
