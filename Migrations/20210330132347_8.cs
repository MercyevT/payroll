using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace projectpayroll.Migrations
{
    public partial class _8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ManagerInfos",
                columns: table => new
                {
                    managerInfoId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    managerInfoFname = table.Column<string>(nullable: true),
                    managerInfoLname = table.Column<string>(nullable: true),
                    managerCZId = table.Column<string>(nullable: true),
                    managerAddress = table.Column<string>(nullable: true),
                    managerCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManagerInfos", x => x.managerInfoId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ManagerInfos");
        }
    }
}
