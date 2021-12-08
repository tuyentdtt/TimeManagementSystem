using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeManagement.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TimeManagement.Configurations
{
    public class FileDinhKemConfigurations : IEntityTypeConfiguration<FileDinhKem>
    {
        public void Configure(EntityTypeBuilder<FileDinhKem> builder)
        {


            builder.ToTable("FileDinhKem");
            builder.HasKey(t => new { t.Id });
            builder.HasOne(t => t.MaCongViec_Fk).WithMany(ur => ur.FileDinhKem)
    .HasForeignKey(pc => pc.MaCongViec);


        }
    }
}
