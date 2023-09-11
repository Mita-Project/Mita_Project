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
                .IsRequired();

            builder.HasMany(x => x.Photographs)
                .WithOne(x => x.Request)
                .HasForeignKey(x => x.RequestId);

            builder.HasOne(x => x.Company)
                .WithMany(x => x.Requests)
                .HasForeignKey(x => x.CompanyId);

            builder.HasOne(x => x.Team)
                .WithMany(x => x.Requests)
                .HasForeignKey(x => x.TeamId);
        }
    }
}
