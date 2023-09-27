using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Configurations
{
    public class Branch_Configuration : BaseConfiguration<Branch>
    {
        public override void Configure(EntityTypeBuilder<Branch> builder)
        {
            base.Configure(builder);

            builder.HasOne(x => x.Company)
                .WithMany(x => x.Branches)
                .HasForeignKey(x => x.CompanyId)
                .IsRequired();

            builder.HasOne(x => x.Maintenance)
                .WithOne(x => x.Branch)
                .HasForeignKey<Branch>(x => x.MaintenanceId);

            builder.HasMany(x => x.Requests)
                .WithOne(x => x.Branch);
                
            builder.HasOne(x=>x.BranchType)
                .WithMany(x => x.Branches)
                .HasForeignKey(x=>x.BranchTypeId)
                .IsRequired();
        }
    }
}
