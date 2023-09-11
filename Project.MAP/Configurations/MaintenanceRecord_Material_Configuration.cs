using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Configurations
{
    public class MaintenanceRecord_Material_Configuration : BaseConfiguration<MaintenanceRecord_Material>
    {
        public override void Configure(EntityTypeBuilder<MaintenanceRecord_Material> builder)
        {
            base.Configure(builder);

            // We don't need an id because this class is an intermediate table and we don't need any id's more than user's and role's id.

            builder.Ignore(x => x.ID);

            // As this is a intermediate table we have to declare the ID's that are meant to be primary key.

            builder.HasKey(x => new
            {
                x.MaterialId,
                x.MaintenanceRecordId
            });
        }
    }
}
