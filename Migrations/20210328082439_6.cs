using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace projectpayroll.Migrations
{
    public partial class _6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_slipSalarys_slipMasters_slipMasterId",
                table: "slipSalarys");

            migrationBuilder.DropIndex(
                name: "IX_slipSalarys_slipMasterId",
                table: "slipSalarys");

            migrationBuilder.DropColumn(
                name: "date",
                table: "slipSalarys");

            migrationBuilder.DropColumn(
                name: "slipMasterId",
                table: "slipSalarys");

            migrationBuilder.DropColumn(
                name: "value",
                table: "slipSalarys");

            migrationBuilder.AddColumn<string>(
                name: "Month",
                table: "slipSalarys",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "NetSalary",
                table: "slipSalarys",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Totaldeducttion",
                table: "slipSalarys",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Totalearning",
                table: "slipSalarys",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Year",
                table: "slipSalarys",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Month",
                table: "slipSalarys");

            migrationBuilder.DropColumn(
                name: "NetSalary",
                table: "slipSalarys");

            migrationBuilder.DropColumn(
                name: "Totaldeducttion",
                table: "slipSalarys");

            migrationBuilder.DropColumn(
                name: "Totalearning",
                table: "slipSalarys");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "slipSalarys");

            migrationBuilder.AddColumn<DateTime>(
                name: "date",
                table: "slipSalarys",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "slipMasterId",
                table: "slipSalarys",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "value",
                table: "slipSalarys",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateIndex(
                name: "IX_slipSalarys_slipMasterId",
                table: "slipSalarys",
                column: "slipMasterId");

            migrationBuilder.AddForeignKey(
                name: "FK_slipSalarys_slipMasters_slipMasterId",
                table: "slipSalarys",
                column: "slipMasterId",
                principalTable: "slipMasters",
                principalColumn: "slipMasterId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
