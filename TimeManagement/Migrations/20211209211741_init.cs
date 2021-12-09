using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TimeManagement.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DuAn",
                columns: table => new
                {
                    MaDuAn = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenDuAn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NguoiTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgaySua = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NguoiSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DuAn", x => x.MaDuAn);
                });

            migrationBuilder.CreateTable(
                name: "PhongBan",
                columns: table => new
                {
                    MaPhong = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenPhong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgaySua = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NguoiTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NguoiSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhongBan", x => x.MaPhong);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrangThai",
                columns: table => new
                {
                    MaTrangThai = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenTrangThai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrangThai", x => x.MaTrangThai);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoB = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MaPhong = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_PhongBan_MaPhong",
                        column: x => x.MaPhong,
                        principalTable: "PhongBan",
                        principalColumn: "MaPhong",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CongViec",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaCongViec = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaTrangThai = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MaDuAn = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MaPhong = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    NguoiThucHien = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoGioThucHien = table.Column<int>(type: "int", nullable: false),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NguoiTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgaySua = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NguoiSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsView = table.Column<bool>(type: "bit", nullable: false),
                    NgayKetThucCV = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CongViec", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CongViec_DuAn_MaDuAn",
                        column: x => x.MaDuAn,
                        principalTable: "DuAn",
                        principalColumn: "MaDuAn",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CongViec_PhongBan_MaPhong",
                        column: x => x.MaPhong,
                        principalTable: "PhongBan",
                        principalColumn: "MaPhong",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CongViec_TrangThai_MaTrangThai",
                        column: x => x.MaTrangThai,
                        principalTable: "TrangThai",
                        principalColumn: "MaTrangThai",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Lich",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Slot1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Slot2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Slot3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Slot4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Slot5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Slot6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Slot7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Slot8 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lich", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lich_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaCongViec = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NguoiTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgaySua = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NguoiSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MoTap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsModifile = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comment_CongViec_MaCongViec",
                        column: x => x.MaCongViec,
                        principalTable: "CongViec",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CongViecSub",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaCongViec = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MaCongViec_Sub = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaTrangThai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenCongViec_Sub = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NguoiThucHien = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoGioThucHien = table.Column<int>(type: "int", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NguoiTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgaySua = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NguoiSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsView = table.Column<bool>(type: "bit", nullable: false),
                    NgayKetThucCV = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CongViecSub", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CongViecSub_CongViec_MaCongViec",
                        column: x => x.MaCongViec,
                        principalTable: "CongViec",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FileDinhKem",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaFile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenFile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaCongViec = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NguoiTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DuongDanFile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileDinhKem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FileDinhKem_CongViec_MaCongViec",
                        column: x => x.MaCongViec,
                        principalTable: "CongViec",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LichSu",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaCongViec = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TieuDe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoDung = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NguoiTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LichSu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LichSu_CongViec_MaCongViec",
                        column: x => x.MaCongViec,
                        principalTable: "CongViec",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "660f87c0-b0b9-4a51-913a-59829345264d", "7c229d0e-6d34-4712-8ff2-c057146692ac", null, "AppRole", "Admin", "ADMIN" },
                    { "796a4128-d5b7-4af3-afd2-b32fa5ec35c4", "87cf09b1-9516-4482-91cc-bd266731f160", null, "AppRole", "Staff", "STAFF" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "DoB", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "MaPhong", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3a8d7e13-d0e2-4afb-93c3-8d0f1226ec95", 0, "68c3b919-9eae-4aa2-92a4-d669b1ec90d7", "AppUser", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tuyen1@gmail.com", true, null, null, false, null, null, null, null, "AQAAAAEAACcQAAAAEJEQTxT7RE28js4I61zdOmq3Hq17dQGIboYk8AnPgcXlwLyVXbIRFIzjegVP4T39Zw==", null, false, "1f3d29af-4931-412e-824f-7432dab70a54", false, null },
                    { "2328a998-48f2-4214-8d7f-52666511df28", 0, "df0783a6-e2da-4e98-b5f5-29b7270a4c11", "AppUser", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", true, null, null, false, null, null, null, null, "AQAAAAEAACcQAAAAEB304UFk6IkMICRFySQAxeyM03M/xf/rgiQBeVyWWN/+6jY42fgM1TUBXXh8aRSPMw==", null, false, "09941fc7-aaa3-428c-88ac-d6466ab1a017", false, null },
                    { "ee9766e6-bd5b-46a5-a2b6-f95e880bd07c", 0, "fd5926de-2fff-4ee4-a95b-e23083014856", "AppUser", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "staf@gmail.com", true, null, null, false, null, null, null, null, "AQAAAAEAACcQAAAAECIace156Gjrb4PY6J7b/nV7lJqRIPxiFStT3CNWXSJzWq2oiCfjsZZAAppMNe+rzQ==", null, false, "2dc7417e-5cc7-45df-b9cb-eaff096213aa", false, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comment_MaCongViec",
                table: "Comment",
                column: "MaCongViec");

            migrationBuilder.CreateIndex(
                name: "IX_CongViec_MaDuAn",
                table: "CongViec",
                column: "MaDuAn");

            migrationBuilder.CreateIndex(
                name: "IX_CongViec_MaPhong",
                table: "CongViec",
                column: "MaPhong");

            migrationBuilder.CreateIndex(
                name: "IX_CongViec_MaTrangThai",
                table: "CongViec",
                column: "MaTrangThai");

            migrationBuilder.CreateIndex(
                name: "IX_CongViecSub_MaCongViec",
                table: "CongViecSub",
                column: "MaCongViec");

            migrationBuilder.CreateIndex(
                name: "IX_FileDinhKem_MaCongViec",
                table: "FileDinhKem",
                column: "MaCongViec");

            migrationBuilder.CreateIndex(
                name: "IX_Lich_UserId",
                table: "Lich",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_LichSu_MaCongViec",
                table: "LichSu",
                column: "MaCongViec");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Roles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_Users_MaPhong",
                table: "Users",
                column: "MaPhong");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Users",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "CongViecSub");

            migrationBuilder.DropTable(
                name: "FileDinhKem");

            migrationBuilder.DropTable(
                name: "Lich");

            migrationBuilder.DropTable(
                name: "LichSu");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "CongViec");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "DuAn");

            migrationBuilder.DropTable(
                name: "TrangThai");

            migrationBuilder.DropTable(
                name: "PhongBan");
        }
    }
}
