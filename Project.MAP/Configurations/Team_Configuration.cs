using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Configurations
{
    public class Team_Configuration : BaseConfiguration<Team>
    {
        public override void Configure(EntityTypeBuilder<Team> builder)
        {
            base.Configure(builder);

            builder.HasMany(x => x.Users)
                .WithOne(x => x.Team);

            builder.HasMany(x => x.Requests)
                .WithOne(x => x.Team)
                .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction);

            builder.HasMany(x => x.MaintenanceRecords)
                .WithOne(x => x.Team);

            builder.HasMany(x => x.ServiceRecords)
                .WithOne(x => x.Team);
        }
    }
}
