using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Configurations
{
    public class Role_Configuration : BaseConfiguration<Role>
    {
        public override void Configure(EntityTypeBuilder<Role> builder)
        {
            base.Configure(builder);

            // We don't need the ID which comes from IEntity because Identity lib. automatically creates an Id !

            builder.Ignore(x => x.ID);

            // We have to declare the relation with the intermediate table here.

            builder.HasMany(x => x.User_Roles)
                .WithOne(x => x.Role)
                .HasForeignKey(x => x.RoleId)
                .IsRequired();

        }
    }
}
