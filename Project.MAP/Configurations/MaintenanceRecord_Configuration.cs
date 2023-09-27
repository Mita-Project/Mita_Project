using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Configurations
{
    public class MaintenanceRecord_Configuration : BaseConfiguration<MaintenanceRecord>
    {
        public override void Configure(EntityTypeBuilder<MaintenanceRecord> builder)
        {
            base.Configure(builder);

            builder.HasOne(x => x.Maintenance)
                .WithMany(x => x.MaintenanceRecords)
                .HasForeignKey(x => x.MaintenanceId)
                .IsRequired();

            builder.HasOne(x => x.Team)
                .WithMany(x => x.MaintenanceRecords)
                .HasForeignKey(x => x.TeamId)
                .IsRequired();

            builder.HasMany(x => x.MaintananceRecord_Materials)
                .WithOne(x => x.MaintenanceRecord);
        }
    }
}
