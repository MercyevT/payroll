using Microsoft.EntityFrameworkCore.Migrations;

namespace projectpayroll.Migrations
{
    public partial class _4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "ssfundR",
                table: "ssfunds",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ssfundR",
                table: "ssfunds");
        }
    }
}
