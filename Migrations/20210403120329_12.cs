using Microsoft.EntityFrameworkCore.Migrations;

namespace projectpayroll.Migrations
{
    public partial class _12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "month",
                table: "CurrentSalarys");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "month",
                table: "CurrentSalarys",
                type: "longtext",
                nullable: true);
        }
    }
}
