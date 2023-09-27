using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Configurations
{
    public class Gadget_Configuration : BaseConfiguration<Gadget>
    {
        public override void Configure(EntityTypeBuilder<Gadget> builder)
        {
            base.Configure(builder);

            builder.HasMany(x => x.Gadget_ServiceRecords)
                .WithOne(x => x.Gadget);

            builder.HasMany(x => x.Gadget_Maintenances)
                .WithOne(x => x.Gadget);
        }
    }
}
