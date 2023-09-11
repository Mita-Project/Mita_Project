using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Configurations
{
    public class Message_Configuration : BaseConfiguration<Message>
    {
        public override void Configure(EntityTypeBuilder<Message> builder)
        {
            base.Configure(builder);

            builder.HasOne(x => x.User)
                .WithMany(x => x.Messages)
                .HasForeignKey(x => x.UserId)
                .IsRequired();

            builder.HasOne(x => x.ServiceRecord)
                .WithMany(x => x.Messages)
                .HasForeignKey(x => x.ServiceRecordId)
                .IsRequired();

            builder.HasMany(x => x.Documents)
                .WithOne(x => x.Message)
                .HasForeignKey(x => x.MessageId)
                .IsRequired();

            builder.HasMany(x => x.Photographs)
                .WithOne(x => x.Message)
                .HasForeignKey(x => x.MessageId);
        }
    }
}
