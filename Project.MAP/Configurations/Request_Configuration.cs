using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Configurations
{
    public class Request_Configuration : BaseConfiguration<Request>
    {
        public override void Configure(EntityTypeBuilder<Request> builder)
        {
            base.Configure(builder);

            builder.HasOne(x => x.Company)
                .WithMany(x => x.Requests)
                .HasForeignKey(x => x.CompanyId)
                .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction)
                .IsRequired();

            builder.HasMany(x => x.Photographs)
                .WithOne(x => x.Request);

            builder.HasOne(x => x.Company)
                .WithMany(x => x.Requests)
                .HasForeignKey(x => x.CompanyId);

            builder.HasOne(x => x.Team)
                .WithMany(x => x.Requests)
                .HasForeignKey(x => x.TeamId)
                .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction);

            builder.HasOne(x => x.ServiceRecord)
                .WithOne(x => x.Request)
                .HasForeignKey<Request>(x => x.ServiceRecordId)
                .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction);

            builder.HasMany(x => x.Documents)
                .WithOne(x => x.Request)
                .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction);

            builder.HasOne(x => x.Offer)
                .WithOne(x => x.Request)
                .HasForeignKey<Request>(x => x.OfferId)
                .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction);
        }
    }
}
