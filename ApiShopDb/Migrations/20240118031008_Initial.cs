using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiShopDb.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserRols",
                columns: table => new
                {
                    UserRolId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRols", x => x.UserRolId);
                });

            migrationBuilder.CreateTable(
                name: "UserSecurities",
                columns: table => new
                {
                    UserInfoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NumberAttempts = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    CancelAccount = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    FailedRegister = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSecurities", x => x.UserInfoId);
                });

            migrationBuilder.CreateTable(
                name: "UserInfos",
                columns: table => new
                {
                    UserInfoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Genre = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfos", x => x.UserInfoId);
                    table.ForeignKey(
                        name: "FK_UserInfos_UserSecurities_UserInfoId",
                        column: x => x.UserInfoId,
                        principalTable: "UserSecurities",
                        principalColumn: "UserInfoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserInfoUserRols",
                columns: table => new
                {
                    UserInfoId = table.Column<int>(type: "int", nullable: false),
                    UserRolId = table.Column<int>(type: "int", nullable: false),
                    UserInfoId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfoUserRols", x => new { x.UserInfoId, x.UserRolId });
                    table.ForeignKey(
                        name: "FK_UserInfoUserRols_UserInfos_UserInfoId1",
                        column: x => x.UserInfoId1,
                        principalTable: "UserInfos",
                        principalColumn: "UserInfoId");
                    table.ForeignKey(
                        name: "FK_UserInfoUserRols_UserRols_UserRolId",
                        column: x => x.UserRolId,
                        principalTable: "UserRols",
                        principalColumn: "UserRolId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserInfos_Email",
                table: "UserInfos",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserInfoUserRols_UserInfoId1",
                table: "UserInfoUserRols",
                column: "UserInfoId1");

            migrationBuilder.CreateIndex(
                name: "IX_UserInfoUserRols_UserRolId",
                table: "UserInfoUserRols",
                column: "UserRolId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserInfoUserRols");

            migrationBuilder.DropTable(
                name: "UserInfos");

            migrationBuilder.DropTable(
                name: "UserRols");

            migrationBuilder.DropTable(
                name: "UserSecurities");
        }
    }
}
