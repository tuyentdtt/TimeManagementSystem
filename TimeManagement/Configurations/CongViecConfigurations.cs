using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeManagement.Entity;

namespace TimeManagement.Configurations
{
    public class CongViecConfigurations : IEntityTypeConfiguration<CongViec>
    {
        public void Configure(EntityTypeBuilder<CongViec> builder)
        {


            builder.ToTable("CongViec");
            builder.HasKey(t => new { t.Id });

            builder.HasOne(t => t.TrangThai_Fk).WithMany(ur => ur.CongViec)
     .HasForeignKey(pc => pc.MaTrangThai);
            builder.HasOne(t => t.MaDuAn_Fk).WithMany(ur => ur.CongViec)
    .HasForeignKey(pc => pc.MaDuAn);
            builder.HasOne(t => t.MaPhongn_Fk).WithMany(ur => ur.CongViec)
    .HasForeignKey(pc => pc.MaPhong);


        }
    }
}
