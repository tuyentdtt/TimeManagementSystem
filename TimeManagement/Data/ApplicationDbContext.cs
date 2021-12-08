using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TimeManagement.Configurations;
using TimeManagement.Entity;


namespace TimeManagement.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public static readonly ILoggerFactory loggerFactory = LoggerFactory.Create(builder => {
            builder
                // .AddFilter (DbLoggerCategory.Database.Command.Name, LogLevel.Warning)
                // .AddFilter (DbLoggerCategory.Query.Name, LogLevel.Debug)
                .AddConsole();
        });

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //// Bỏ tiền tố AspNet của các bảng: mặc định các bảng trong IdentityDbContext có
            //// tên với tiền tố AspNet như: AspNetUserRoles, AspNetUser ...
            //// Đoạn mã sau chạy khi khởi tạo DbContext, tạo database sẽ loại bỏ tiền tố đó
            foreach (var entityType in builder.Model.GetEntityTypes())
            {
                var tableName = entityType.GetTableName();
                if (tableName.StartsWith("AspNet"))
                {
                    entityType.SetTableName(tableName.Substring(6));
                }
            }










            //builder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims");
            //builder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRole").HasKey(x => new { x.UserId, x.RoleId });
            //builder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);
            //builder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppUserRoleClaims");
            //builder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(x => x.UserId);

            builder.ApplyConfiguration(new AppRoleConfigurations());
            builder.ApplyConfiguration(new AppUserConfigurations());
            builder.ApplyConfiguration(new CommentConfigurations());
            builder.ApplyConfiguration(new CongViecConfigurations());
            builder.ApplyConfiguration(new CongViecSubConfigurations());
            builder.ApplyConfiguration(new DuAnConfigurations());
            builder.ApplyConfiguration(new FileDinhKemConfigurations());
            builder.ApplyConfiguration(new LichSuConfigurations());
            builder.ApplyConfiguration(new PhongBanConfigurations());
            builder.ApplyConfiguration(new TrangThaiConfigurations());



            builder.Seed();


        }


        public DbSet<AppRole> AppRole { set; get; }
        public DbSet<AppUser> AppUser { set; get; }
        public DbSet<Comment> Comment { set; get; }
        public DbSet<CongViec> CongViec { set; get; }
        public DbSet<CongViecSub> CongViecSub { set; get; }
        public DbSet<DuAn> DuAn { set; get; }
        public DbSet<FileDinhKem> FileDinhKem { set; get; }
        public DbSet<LichSu> LichSu { set; get; }
        public DbSet<PhongBan> PhongBan { set; get; }
        public DbSet<TrangThai> TrangThai { set; get; }


    }
}
