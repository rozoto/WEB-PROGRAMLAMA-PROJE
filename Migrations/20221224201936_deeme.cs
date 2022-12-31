using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace odevvv.Migrations
{
    /// <inheritdoc />
    public partial class deeme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Hayvanlars",
                columns: table => new
                {
                    HayvanID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HayvanName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HayvanIrk = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HayvanAgirlik = table.Column<int>(type: "int", nullable: false),
                    HayvanCinsiyet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HayvanYas = table.Column<int>(type: "int", nullable: false),
                    HayvanCins = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hayvanİmage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hayvanlars", x => x.HayvanID);
                });

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AdminID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kullanici = table.Column<string>(type: "VarChar(20)", nullable: true),
                    Sifre = table.Column<string>(type: "VarChar(10)", nullable: true),
                    AdminRoleRoleID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AdminID);
                    table.ForeignKey(
                        name: "FK_Admins_AdminRole_AdminRoleRoleID",
                        column: x => x.AdminRoleRoleID,
                        principalTable: "AdminRole",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Admins_AdminRoleRoleID",
                table: "Admins",
                column: "AdminRoleRoleID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Hayvanlars");

            migrationBuilder.DropTable(
                name: "AdminRole");
        }
    }
}
