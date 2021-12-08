using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeManagement.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TimeManagement.Configurations
{
    public class TrangThaiConfigurations : IEntityTypeConfiguration<TrangThai>
    {
        public void Configure(EntityTypeBuilder<TrangThai> builder)
        {


            builder.ToTable("TrangThai");
            builder.HasKey(t => new { t.MaTrangThai });


        }
    }
}
