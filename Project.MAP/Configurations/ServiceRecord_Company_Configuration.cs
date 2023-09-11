using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Configurations
{
    public class ServiceRecord_Company_Configuration : BaseConfiguration<ServiceRecord_Company>
    {
        public override void Configure(EntityTypeBuilder<ServiceRecord_Company> builder)
        {
            base.Configure(builder);

            // We don't need an id because this class is an intermediate table and we don't need any id's more than user's and role's id.

            builder.Ignore(x => x.ID);

            // As this is a intermediate table we have to declare the ID's that are meant to be primary key.

            builder.HasKey(x => new
            {
                x.ServiceRecordId,
                x.CompanyId
            });
        }
    }
}
