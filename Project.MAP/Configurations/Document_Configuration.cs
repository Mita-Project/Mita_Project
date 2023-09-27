using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Configurations
{
    public class Document_Configuration : BaseConfiguration<Document>
    {
        public override void Configure(EntityTypeBuilder<Document> builder)
        {
            base.Configure(builder);

            builder.HasOne(x => x.Message)
                .WithMany(x => x.Documents)
                .HasForeignKey(x => x.MessageId)
                .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction);

            builder.HasOne(x => x.EMail)
                .WithMany(x => x.Documents)
                .HasForeignKey(x => x.EMailId);

            builder.HasOne(x => x.Request)
                .WithMany(x => x.Documents)
                .HasForeignKey(x => x.RequestId)
                .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction);
        }
    }
}
