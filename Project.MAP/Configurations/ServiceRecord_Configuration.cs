using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Configurations
{
    public class ServiceRecord_Configuration : BaseConfiguration<ServiceRecord>
    {
        public override void Configure(EntityTypeBuilder<ServiceRecord> builder)
        {
            base.Configure(builder);

            builder.HasMany(x => x.Photographs)
                .WithOne(x => x.ServiceRecord)
                .HasForeignKey(x => x.ServiceRecordId);

            builder.HasOne(x => x.Request)
                .WithOne(x => x.ServiceRecord);

            builder.HasOne(x => x.Team)
                .WithMany(x => x.ServiceRecords)
                .HasForeignKey(x => x.TeamId)
                .IsRequired();

            builder.HasMany(x => x.EMail)
                .WithOne(x => x.ServiceRecord)
                .HasForeignKey(x => x.ServiceRecordId);

            builder.HasMany(x => x.ServiceRecord_Materials)
                .WithOne(x => x.ServiceRecord)
                .HasForeignKey(x => x.ServiceRecordId);

            builder.HasMany(x => x.ServiceRecord_Companies)
                .WithOne(x => x.ServiceRecord)
                .HasForeignKey(x => x.ServiceRecordId);
                
            builder.HasMany(x => x.ServiceRecord_Users)
                .WithOne(x => x.ServiceRecord)
                .HasForeignKey (x => x.ServiceRecordId);

            builder.HasMany(x => x.Messages)
                .WithOne(x => x.ServiceRecord)
                .HasForeignKey(x => x.ServiceRecordId);
        }
    }
}
