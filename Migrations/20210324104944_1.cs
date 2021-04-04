using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace projectpayroll.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "banks",
                columns: table => new
                {
                    bankId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    bankName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_banks", x => x.bankId);
                });

            migrationBuilder.CreateTable(
                name: "departments",
                columns: table => new
                {
                    departmentId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    departmentName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departments", x => x.departmentId);
                });

            migrationBuilder.CreateTable(
                name: "InfoMasters",
                columns: table => new
                {
                    InfoMasterId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    information = table.Column<string>(nullable: true),
                    value = table.Column<double>(nullable: false),
                    year = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfoMasters", x => x.InfoMasterId);
                });

            migrationBuilder.CreateTable(
                name: "slipMasters",
                columns: table => new
                {
                    slipMasterId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    slipMasterName = table.Column<string>(nullable: true),
                    slipMasterType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_slipMasters", x => x.slipMasterId);
                });

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    employeeId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Position = table.Column<string>(nullable: true),
                    departmentId = table.Column<int>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    bankId = table.Column<int>(nullable: false),
                    BankAccount = table.Column<string>(nullable: true),
                    CitizenID = table.Column<string>(nullable: true),
                    PassportNo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.employeeId);
                    table.ForeignKey(
                        name: "FK_employees_banks_bankId",
                        column: x => x.bankId,
                        principalTable: "banks",
                        principalColumn: "bankId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_employees_departments_departmentId",
                        column: x => x.departmentId,
                        principalTable: "departments",
                        principalColumn: "departmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeSalaryMasters",
                columns: table => new
                {
                    employeeSalaryMasterId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    departmentId = table.Column<int>(nullable: false),
                    position = table.Column<string>(nullable: true),
                    employeestatus = table.Column<string>(nullable: true),
                    basicSalary = table.Column<double>(nullable: false),
                    salaryRate = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeSalaryMasters", x => x.employeeSalaryMasterId);
                    table.ForeignKey(
                        name: "FK_EmployeeSalaryMasters_departments_departmentId",
                        column: x => x.departmentId,
                        principalTable: "departments",
                        principalColumn: "departmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OTrates",
                columns: table => new
                {
                    oTrateId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    departmentId = table.Column<int>(nullable: false),
                    position = table.Column<string>(nullable: true),
                    value = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OTrates", x => x.oTrateId);
                    table.ForeignKey(
                        name: "FK_OTrates_departments_departmentId",
                        column: x => x.departmentId,
                        principalTable: "departments",
                        principalColumn: "departmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "workingTimes",
                columns: table => new
                {
                    workingTimeId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    departmentId = table.Column<int>(nullable: false),
                    start = table.Column<string>(nullable: true),
                    finish = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_workingTimes", x => x.workingTimeId);
                    table.ForeignKey(
                        name: "FK_workingTimes_departments_departmentId",
                        column: x => x.departmentId,
                        principalTable: "departments",
                        principalColumn: "departmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "clockings",
                columns: table => new
                {
                    clockingId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    employeeId = table.Column<int>(nullable: false),
                    clockingIn = table.Column<string>(nullable: true),
                    breakIn = table.Column<string>(nullable: true),
                    breakOut = table.Column<string>(nullable: true),
                    clockingOut = table.Column<string>(nullable: true),
                    Date = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clockings", x => x.clockingId);
                    table.ForeignKey(
                        name: "FK_clockings_employees_employeeId",
                        column: x => x.employeeId,
                        principalTable: "employees",
                        principalColumn: "employeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeInfos",
                columns: table => new
                {
                    employeeInfoId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    employeeId = table.Column<int>(nullable: false),
                    InfoMasterId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeInfos", x => x.employeeInfoId);
                    table.ForeignKey(
                        name: "FK_EmployeeInfos_InfoMasters_InfoMasterId",
                        column: x => x.InfoMasterId,
                        principalTable: "InfoMasters",
                        principalColumn: "InfoMasterId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeInfos_employees_employeeId",
                        column: x => x.employeeId,
                        principalTable: "employees",
                        principalColumn: "employeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OTs",
                columns: table => new
                {
                    oTId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    employeeId = table.Column<int>(nullable: false),
                    oTStart = table.Column<string>(nullable: true),
                    oTFinish = table.Column<string>(nullable: true),
                    oTDate = table.Column<string>(nullable: true),
                    TotalHour = table.Column<int>(nullable: false),
                    oStatus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OTs", x => x.oTId);
                    table.ForeignKey(
                        name: "FK_OTs_employees_employeeId",
                        column: x => x.employeeId,
                        principalTable: "employees",
                        principalColumn: "employeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "slipSalarys",
                columns: table => new
                {
                    slipSalaryId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    employeeId = table.Column<int>(nullable: false),
                    slipMasterId = table.Column<int>(nullable: false),
                    value = table.Column<double>(nullable: false),
                    date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_slipSalarys", x => x.slipSalaryId);
                    table.ForeignKey(
                        name: "FK_slipSalarys_employees_employeeId",
                        column: x => x.employeeId,
                        principalTable: "employees",
                        principalColumn: "employeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_slipSalarys_slipMasters_slipMasterId",
                        column: x => x.slipMasterId,
                        principalTable: "slipMasters",
                        principalColumn: "slipMasterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ssfunds",
                columns: table => new
                {
                    ssfundId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    employeeId = table.Column<int>(nullable: false),
                    value = table.Column<int>(nullable: false),
                    month = table.Column<string>(nullable: true),
                    year = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ssfunds", x => x.ssfundId);
                    table.ForeignKey(
                        name: "FK_ssfunds_employees_employeeId",
                        column: x => x.employeeId,
                        principalTable: "employees",
                        principalColumn: "employeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "taxs",
                columns: table => new
                {
                    taxId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    employeeId = table.Column<int>(nullable: false),
                    netSalary = table.Column<double>(nullable: false),
                    taxY = table.Column<double>(nullable: false),
                    year = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_taxs", x => x.taxId);
                    table.ForeignKey(
                        name: "FK_taxs_employees_employeeId",
                        column: x => x.employeeId,
                        principalTable: "employees",
                        principalColumn: "employeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CurrentSalarys",
                columns: table => new
                {
                    currentSalaryId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    employeeId = table.Column<int>(nullable: false),
                    employeeSalaryMasterId = table.Column<int>(nullable: false),
                    currentSalaryAmount = table.Column<double>(nullable: false),
                    month = table.Column<string>(nullable: true),
                    year = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrentSalarys", x => x.currentSalaryId);
                    table.ForeignKey(
                        name: "FK_CurrentSalarys_employees_employeeId",
                        column: x => x.employeeId,
                        principalTable: "employees",
                        principalColumn: "employeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CurrentSalarys_EmployeeSalaryMasters_employeeSalaryMasterId",
                        column: x => x.employeeSalaryMasterId,
                        principalTable: "EmployeeSalaryMasters",
                        principalColumn: "employeeSalaryMasterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OTCs",
                columns: table => new
                {
                    oTCId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    oTId = table.Column<int>(nullable: false),
                    value = table.Column<int>(nullable: false),
                    month = table.Column<string>(nullable: true),
                    years = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OTCs", x => x.oTCId);
                    table.ForeignKey(
                        name: "FK_OTCs_OTs_oTId",
                        column: x => x.oTId,
                        principalTable: "OTs",
                        principalColumn: "oTId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_clockings_employeeId",
                table: "clockings",
                column: "employeeId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrentSalarys_employeeId",
                table: "CurrentSalarys",
                column: "employeeId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrentSalarys_employeeSalaryMasterId",
                table: "CurrentSalarys",
                column: "employeeSalaryMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInfos_InfoMasterId",
                table: "EmployeeInfos",
                column: "InfoMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInfos_employeeId",
                table: "EmployeeInfos",
                column: "employeeId");

            migrationBuilder.CreateIndex(
                name: "IX_employees_bankId",
                table: "employees",
                column: "bankId");

            migrationBuilder.CreateIndex(
                name: "IX_employees_departmentId",
                table: "employees",
                column: "departmentId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeSalaryMasters_departmentId",
                table: "EmployeeSalaryMasters",
                column: "departmentId");

            migrationBuilder.CreateIndex(
                name: "IX_OTCs_oTId",
                table: "OTCs",
                column: "oTId");

            migrationBuilder.CreateIndex(
                name: "IX_OTrates_departmentId",
                table: "OTrates",
                column: "departmentId");

            migrationBuilder.CreateIndex(
                name: "IX_OTs_employeeId",
                table: "OTs",
                column: "employeeId");

            migrationBuilder.CreateIndex(
                name: "IX_slipSalarys_employeeId",
                table: "slipSalarys",
                column: "employeeId");

            migrationBuilder.CreateIndex(
                name: "IX_slipSalarys_slipMasterId",
                table: "slipSalarys",
                column: "slipMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_ssfunds_employeeId",
                table: "ssfunds",
                column: "employeeId");

            migrationBuilder.CreateIndex(
                name: "IX_taxs_employeeId",
                table: "taxs",
                column: "employeeId");

            migrationBuilder.CreateIndex(
                name: "IX_workingTimes_departmentId",
                table: "workingTimes",
                column: "departmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "clockings");

            migrationBuilder.DropTable(
                name: "CurrentSalarys");

            migrationBuilder.DropTable(
                name: "EmployeeInfos");

            migrationBuilder.DropTable(
                name: "OTCs");

            migrationBuilder.DropTable(
                name: "OTrates");

            migrationBuilder.DropTable(
                name: "slipSalarys");

            migrationBuilder.DropTable(
                name: "ssfunds");

            migrationBuilder.DropTable(
                name: "taxs");

            migrationBuilder.DropTable(
                name: "workingTimes");

            migrationBuilder.DropTable(
                name: "EmployeeSalaryMasters");

            migrationBuilder.DropTable(
                name: "InfoMasters");

            migrationBuilder.DropTable(
                name: "OTs");

            migrationBuilder.DropTable(
                name: "slipMasters");

            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "banks");

            migrationBuilder.DropTable(
                name: "departments");
        }
    }
}
