using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeManagement.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TimeManagement.Configurations
{
    public class DuAnConfigurations : IEntityTypeConfiguration<DuAn>
    {
        public void Configure(EntityTypeBuilder<DuAn> builder)
        {


            builder.ToTable("DuAn");
            builder.HasKey(t => new { t.MaDuAn });


        }
    }
}
