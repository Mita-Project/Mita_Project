using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Configurations
{
    public class Maintenance_Configuration:BaseConfiguration<Maintenance>
    {
        public override void Configure(EntityTypeBuilder<Maintenance> builder)
        {
            base.Configure(builder);

            builder.HasOne(x => x.Company)
                .WithMany(x => x.Maintenances)
                .HasForeignKey(x => x.CompanyId)
                .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction)
                .IsRequired();

            builder.HasMany(x => x.MaintenanceRecords)
                .WithOne(x => x.Maintenance);

            builder.HasMany(x => x.Gadget_Maintenances)
                .WithOne(x => x.Maintenance)
                .IsRequired();

            builder.HasOne(x => x.MaintenanceType)
                .WithMany(x => x.Maintenances)
                .HasForeignKey(x => x.MaintenanceTypeId)
                .IsRequired();

            builder.HasOne(x => x.Branch)
                .WithOne(x => x.Maintenance)
                .HasForeignKey<Maintenance>(x => x.BranchId);
        }
    }
}
