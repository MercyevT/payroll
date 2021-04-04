using Microsoft.EntityFrameworkCore.Migrations;

namespace projectpayroll.Migrations
{
    public partial class _5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ssfundR",
                table: "ssfunds");

            migrationBuilder.DropColumn(
                name: "value",
                table: "ssfunds");

            migrationBuilder.AddColumn<int>(
                name: "amountE",
                table: "ssfunds",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "amountM",
                table: "ssfunds",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "ssfundER",
                table: "ssfunds",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ssfundMR",
                table: "ssfunds",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "amountE",
                table: "ssfunds");

            migrationBuilder.DropColumn(
                name: "amountM",
                table: "ssfunds");

            migrationBuilder.DropColumn(
                name: "ssfundER",
                table: "ssfunds");

            migrationBuilder.DropColumn(
                name: "ssfundMR",
                table: "ssfunds");

            migrationBuilder.AddColumn<double>(
                name: "ssfundR",
                table: "ssfunds",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "value",
                table: "ssfunds",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
