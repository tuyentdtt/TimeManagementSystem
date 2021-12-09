using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeManagement.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TimeManagement.Configurations
{
    public class LichConfigurations : IEntityTypeConfiguration<Lich>
    {

        public void Configure(EntityTypeBuilder<Lich> builder)
        {
            builder.ToTable("Lich");
            builder.HasKey(t => new { t.Id });

            builder.HasOne(t => t.AppUser_Fk).WithMany(ur => ur.Lich)
            .HasForeignKey(pc => pc.UserId);
            builder.HasOne(t => t.CongViec_Fk).WithMany(ur => ur.Lich)
            .HasForeignKey(pc => pc.CongViecId);


        }
    }
}
