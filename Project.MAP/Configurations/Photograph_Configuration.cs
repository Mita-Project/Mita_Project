using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Configurations
{
    public class Photograph_Configuration : BaseConfiguration<Photograph>
    {
        public override void Configure(EntityTypeBuilder<Photograph> builder)
        {
            base.Configure(builder);

            builder.HasOne(x => x.Request)
                .WithMany(x => x.Photographs)
                .HasForeignKey(x => x.RequestId)
                .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction);

            builder.HasOne(x => x.ServiceRecord)
                .WithMany(x => x.Photographs)
                .HasForeignKey(x => x.ServiceRecordId)
                .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction);

            builder.HasOne(x => x.Message)
                .WithMany(x => x.Photographs)
                .HasForeignKey(x =>x.MessageId)
                .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction);
        }
    }
}
