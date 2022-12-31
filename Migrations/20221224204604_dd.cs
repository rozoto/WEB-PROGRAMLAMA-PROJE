using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace odevvv.Migrations
{
    /// <inheritdoc />
    public partial class dd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admins_AdminRole_AdminRoleRoleID",
                table: "Admins");

            migrationBuilder.DropTable(
                name: "AdminRole");

            migrationBuilder.DropIndex(
                name: "IX_Admins_AdminRoleRoleID",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "AdminRoleRoleID",
                table: "Admins");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdminRoleRoleID",
                table: "Admins",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AdminRole",
                columns: table => new
                {
                    RoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminRole", x => x.RoleID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Admins_AdminRoleRoleID",
                table: "Admins",
                column: "AdminRoleRoleID");

            migrationBuilder.AddForeignKey(
                name: "FK_Admins_AdminRole_AdminRoleRoleID",
                table: "Admins",
                column: "AdminRoleRoleID",
                principalTable: "AdminRole",
                principalColumn: "RoleID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
