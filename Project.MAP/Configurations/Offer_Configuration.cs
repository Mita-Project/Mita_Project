using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Configurations
{
    public class Offer_Configuration : BaseConfiguration<Offer>
    {
        public override void Configure(EntityTypeBuilder<Offer> builder)
        {
            base.Configure(builder);

            builder.HasOne(x => x.User)
                .WithMany(x => x.Offers)
                .HasForeignKey(x => x.UserId);

            builder.HasOne(x => x.ServiceRecord)
                .WithOne(x => x.Offer)
                .HasForeignKey<Offer>(x => x.ServiceRecordId)
                .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction);

            builder.HasOne(x => x.Request)
                .WithOne(x => x.Offer)
                .HasForeignKey<Offer>(x => x.RequestId)
                .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction);

            builder.HasMany(x => x.Offer_Companies)
                .WithOne(x => x.Offer);
        }
    }
}
