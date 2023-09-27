using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Configurations
{
    public class User_Configuration : BaseConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);

            // We don't need the ID which comes from IEntity because Identity lib. automatically creates an Id !

            builder.Ignore(x => x.ID);

            // We have to declare the relation with the intermediate tables here.

            builder.HasMany(x => x.User_Roles)
                .WithOne(x => x.User)
                .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction);

            builder.HasMany(x => x.ServiceRecord_Users)
                .WithOne(x => x.User)
                .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction);

            builder.HasMany(x => x.Offers)
                .WithOne(x => x.User);

            builder.HasOne(x => x.Team)
                .WithMany(x => x.Users)
                .HasForeignKey(x => x.TeamId);
        }
    }
}
