using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Configurations
{
    public class Company_Configuration : BaseConfiguration<Company>
    {
        public override void Configure(EntityTypeBuilder<Company> builder)
        {
            base.Configure(builder);

            builder.HasMany(x => x.Requests)
                .WithOne(x => x.Company)
                .HasForeignKey(x => x.CompanyId)
                .IsRequired();

            builder.HasMany(x => x.ServiceRecord_Companies)
                .WithOne(x => x.Company)
                .HasForeignKey(x => x.CompanyId)
                .IsRequired();
        }
    }
}
