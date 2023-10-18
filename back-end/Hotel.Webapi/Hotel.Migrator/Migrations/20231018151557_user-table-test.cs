using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel.Migrator.Migrations
{
    /// <inheritdoc />
    public partial class usertabletest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_UserConfig_UserConfigId",
                schema: "UserSchema",
                table: "User");

            migrationBuilder.DropTable(
                name: "UserConfig",
                schema: "UserSchema");

            migrationBuilder.DropIndex(
                name: "IX_User_UserConfigId",
                schema: "UserSchema",
                table: "User");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserConfig",
                schema: "UserSchema",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserConfig", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_UserConfigId",
                schema: "UserSchema",
                table: "User",
                column: "UserConfigId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_User_UserConfig_UserConfigId",
                schema: "UserSchema",
                table: "User",
                column: "UserConfigId",
                principalSchema: "UserSchema",
                principalTable: "UserConfig",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
