using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeManagement.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TimeManagement.Configurations
{
    public class CongViecSubConfigurations : IEntityTypeConfiguration<CongViecSub>
    {
        public void Configure(EntityTypeBuilder<CongViecSub> builder)
        {


            builder.ToTable("CongViecSub");
            builder.HasKey(t => new { t.Id });
            builder.HasOne(t => t.MaCongViec_Fk).WithMany(ur => ur.CongViecSub)
     .HasForeignKey(pc => pc.MaCongViec);
            
        }
    }
}
