using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeManagement.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TimeManagement.Configurations
{
    public class CommentConfigurations: IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {


            builder.ToTable("Comment");
            builder.HasKey(t => new { t.Id });
            builder.HasOne(t => t.MaCongViec_Fk).WithMany(ur => ur.Comment)
    .HasForeignKey(pc => pc.MaCongViec);


        }
    }
}
