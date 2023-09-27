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
                .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction);

            builder.HasMany(x => x.ServiceRecord_Companies)
                .WithOne(x => x.Company);

            builder.HasMany(x => x.Maintenances)
                .WithOne(x => x.Company);
        }
    }
}
