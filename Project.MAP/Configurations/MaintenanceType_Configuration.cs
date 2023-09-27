using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Configurations
{
    public class MaintenanceType_Configuration : BaseConfiguration<MaintenanceType>
    {
        public override void Configure(EntityTypeBuilder<MaintenanceType> builder)
        {
            base.Configure(builder);

            builder.HasMany(x => x.Maintenances)
                .WithOne(x => x.MaintenanceType);
        }
    }
}
