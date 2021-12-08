using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using TimeManagement.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TimeManagement.Configurations
{
    public class AppUserConfigurations : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {


            builder.HasOne(t => t.PhongBan_Fk).WithMany(ur => ur.AppUser)
.HasForeignKey(pc => pc.MaPhong);


        }
    }
}
