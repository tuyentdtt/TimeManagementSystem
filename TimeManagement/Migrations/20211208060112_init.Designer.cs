﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TimeManagement.Data;

namespace TimeManagement.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211208060112_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Roles");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityRole");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("TimeManagement.Entity.Comment", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<bool>("IsModifile")
                        .HasColumnType("bit");

                    b.Property<string>("MaCongViec")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MoTap")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgaySua")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<string>("NguoiSua")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NguoiTao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MaCongViec");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("TimeManagement.Entity.CongViec", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<bool>("IsView")
                        .HasColumnType("bit");

                    b.Property<string>("MaCongViec")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaDuAn")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MaPhong")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MaTrangThai")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("NgayBatDau")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayKetThuc")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayKetThucCV")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgaySua")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<string>("NguoiSua")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NguoiTao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NguoiThucHien")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoGioThucHien")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MaDuAn");

                    b.HasIndex("MaPhong");

                    b.HasIndex("MaTrangThai");

                    b.ToTable("CongViec");
                });

            modelBuilder.Entity("TimeManagement.Entity.CongViecSub", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<bool>("IsView")
                        .HasColumnType("bit");

                    b.Property<string>("MaCongViec")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MaCongViec_Sub")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaTrangThai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayBatDau")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayKetThuc")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayKetThucCV")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgaySua")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<string>("NguoiSua")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NguoiTao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NguoiThucHien")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoGioThucHien")
                        .HasColumnType("int");

                    b.Property<string>("TenCongViec_Sub")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MaCongViec");

                    b.ToTable("CongViecSub");
                });

            modelBuilder.Entity("TimeManagement.Entity.DuAn", b =>
                {
                    b.Property<string>("MaDuAn")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<DateTime>("NgayBatDau")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayKetThuc")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgaySua")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<string>("NguoiSua")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NguoiTao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenDuAn")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaDuAn");

                    b.ToTable("DuAn");
                });

            modelBuilder.Entity("TimeManagement.Entity.FileDinhKem", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DuongDanFile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("MaCongViec")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MaFile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<string>("NguoiTao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenFile")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MaCongViec");

                    b.ToTable("FileDinhKem");
                });

            modelBuilder.Entity("TimeManagement.Entity.LichSu", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("MaCongViec")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<string>("NguoiTao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NoDung")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TieuDe")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MaCongViec");

                    b.ToTable("LichSu");
                });

            modelBuilder.Entity("TimeManagement.Entity.PhongBan", b =>
                {
                    b.Property<string>("MaPhong")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<DateTime>("NgaySua")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<string>("NguoiSua")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NguoiTao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenPhong")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaPhong");

                    b.ToTable("PhongBan");
                });

            modelBuilder.Entity("TimeManagement.Entity.TrangThai", b =>
                {
                    b.Property<string>("MaTrangThai")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenTrangThai")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaTrangThai");

                    b.ToTable("TrangThai");
                });

            modelBuilder.Entity("TimeManagement.Entity.AppRole", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityRole");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("AppRole");
                });

            modelBuilder.Entity("TimeManagement.Entity.AppUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<DateTime>("DoB")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaPhong")
                        .HasColumnType("nvarchar(450)");

                    b.HasIndex("MaPhong");

                    b.HasDiscriminator().HasValue("AppUser");

                    b.HasData(
                        new
                        {
                            Id = "fb7479ce-35a0-4a30-be73-92128d7f815c",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "036eed1b-09dc-4538-9cc0-04a518ee7513",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "42d283df-f3a3-4b70-abf6-daaccadb6e68",
                            TwoFactorEnabled = false,
                            DoB = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Tuyen"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TimeManagement.Entity.Comment", b =>
                {
                    b.HasOne("TimeManagement.Entity.CongViec", "MaCongViec_Fk")
                        .WithMany("Comment")
                        .HasForeignKey("MaCongViec");

                    b.Navigation("MaCongViec_Fk");
                });

            modelBuilder.Entity("TimeManagement.Entity.CongViec", b =>
                {
                    b.HasOne("TimeManagement.Entity.DuAn", "MaDuAn_Fk")
                        .WithMany("CongViec")
                        .HasForeignKey("MaDuAn");

                    b.HasOne("TimeManagement.Entity.PhongBan", "MaPhongn_Fk")
                        .WithMany("CongViec")
                        .HasForeignKey("MaPhong");

                    b.HasOne("TimeManagement.Entity.TrangThai", "TrangThai_Fk")
                        .WithMany("CongViec")
                        .HasForeignKey("MaTrangThai");

                    b.Navigation("MaDuAn_Fk");

                    b.Navigation("MaPhongn_Fk");

                    b.Navigation("TrangThai_Fk");
                });

            modelBuilder.Entity("TimeManagement.Entity.CongViecSub", b =>
                {
                    b.HasOne("TimeManagement.Entity.CongViec", "MaCongViec_Fk")
                        .WithMany("CongViecSub")
                        .HasForeignKey("MaCongViec");

                    b.Navigation("MaCongViec_Fk");
                });

            modelBuilder.Entity("TimeManagement.Entity.FileDinhKem", b =>
                {
                    b.HasOne("TimeManagement.Entity.CongViec", "MaCongViec_Fk")
                        .WithMany("FileDinhKem")
                        .HasForeignKey("MaCongViec");

                    b.Navigation("MaCongViec_Fk");
                });

            modelBuilder.Entity("TimeManagement.Entity.LichSu", b =>
                {
                    b.HasOne("TimeManagement.Entity.CongViec", "MaCongViec_Fk")
                        .WithMany("LichSu")
                        .HasForeignKey("MaCongViec");

                    b.Navigation("MaCongViec_Fk");
                });

            modelBuilder.Entity("TimeManagement.Entity.AppUser", b =>
                {
                    b.HasOne("TimeManagement.Entity.PhongBan", "PhongBan_Fk")
                        .WithMany("AppUser")
                        .HasForeignKey("MaPhong");

                    b.Navigation("PhongBan_Fk");
                });

            modelBuilder.Entity("TimeManagement.Entity.CongViec", b =>
                {
                    b.Navigation("Comment");

                    b.Navigation("CongViecSub");

                    b.Navigation("FileDinhKem");

                    b.Navigation("LichSu");
                });

            modelBuilder.Entity("TimeManagement.Entity.DuAn", b =>
                {
                    b.Navigation("CongViec");
                });

            modelBuilder.Entity("TimeManagement.Entity.PhongBan", b =>
                {
                    b.Navigation("AppUser");

                    b.Navigation("CongViec");
                });

            modelBuilder.Entity("TimeManagement.Entity.TrangThai", b =>
                {
                    b.Navigation("CongViec");
                });
#pragma warning restore 612, 618
        }
    }
}
