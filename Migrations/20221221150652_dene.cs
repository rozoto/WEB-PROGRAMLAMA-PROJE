using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace yeni.Migrations
{
    /// <inheritdoc />
    public partial class dene : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AdminID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kullanici = table.Column<string>(type: "VarChar(20)", nullable: true),
                    Sifre = table.Column<string>(type: "VarChar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AdminID);
                });

            migrationBuilder.CreateTable(
                name: "Hayvanlars",
                columns: table => new
                {
                    HayvanID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HayvanName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HayvanIrk = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HayvanYas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hayvanlars", x => x.HayvanID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Hayvanlars");
        }
    }
}
