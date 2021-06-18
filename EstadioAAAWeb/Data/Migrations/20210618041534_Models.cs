using Microsoft.EntityFrameworkCore.Migrations;

namespace EstadioAAAWeb.Data.Migrations
{
    public partial class Models : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admin_User_UserUUID1",
                table: "Admin");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Admin",
                table: "Admin");

            migrationBuilder.DropIndex(
                name: "IX_Admin_UserUUID1",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "UserUUID1",
                table: "Admin");

            migrationBuilder.AlterColumn<string>(
                name: "UserUUID",
                table: "Admin",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "AdminKey",
                table: "Admin",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Admin",
                table: "Admin",
                column: "AdminKey");

            migrationBuilder.CreateIndex(
                name: "IX_Admin_UserUUID",
                table: "Admin",
                column: "UserUUID");

            migrationBuilder.AddForeignKey(
                name: "FK_Admin_User_UserUUID",
                table: "Admin",
                column: "UserUUID",
                principalTable: "User",
                principalColumn: "UserUUID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admin_User_UserUUID",
                table: "Admin");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Admin",
                table: "Admin");

            migrationBuilder.DropIndex(
                name: "IX_Admin_UserUUID",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "AdminKey",
                table: "Admin");

            migrationBuilder.AlterColumn<string>(
                name: "UserUUID",
                table: "Admin",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserUUID1",
                table: "Admin",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Admin",
                table: "Admin",
                column: "UserUUID");

            migrationBuilder.CreateIndex(
                name: "IX_Admin_UserUUID1",
                table: "Admin",
                column: "UserUUID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Admin_User_UserUUID1",
                table: "Admin",
                column: "UserUUID1",
                principalTable: "User",
                principalColumn: "UserUUID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
