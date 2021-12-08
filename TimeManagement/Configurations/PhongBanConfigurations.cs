using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeManagement.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TimeManagement.Configurations
{
    public class PhongBanConfigurations : IEntityTypeConfiguration<PhongBan>
    {
        public void Configure(EntityTypeBuilder<PhongBan> builder)
        {


            builder.ToTable("PhongBan");
            builder.HasKey(t => new { t.MaPhong });


        }
    }
}
