using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeManagement.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TimeManagement.Configurations
{
    public class LichSuConfigurations : IEntityTypeConfiguration<LichSu>
{
        public void Configure(EntityTypeBuilder<LichSu> builder)
        {


            builder.ToTable("LichSu");
            builder.HasKey(t => new { t.Id });
            builder.HasOne(t => t.MaCongViec_Fk).WithMany(ur => ur.LichSu)
    .HasForeignKey(pc => pc.MaCongViec);

        }
    }
}
