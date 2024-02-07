using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataMigration.Migrations
{
    public partial class fm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeMemberHistories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeMemberHistories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeaveBalanceHistories",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<string>(nullable: true),
                    UsedDays = table.Column<int>(nullable: false),
                    RemainingDays = table.Column<string>(nullable: true),
                    LeaveType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveBalanceHistories", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "LeaveRequestHistories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(nullable: false),
                    LeaveTypeId = table.Column<int>(nullable: false),
                    NoOfDays = table.Column<int>(nullable: false),
                    DateFrom = table.Column<DateTime>(nullable: false),
                    DateTo = table.Column<DateTime>(nullable: false),
                    ResumptionDate = table.Column<DateTime>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    DateOfRequest = table.Column<DateTime>(nullable: false),
                    DateOfLastAction = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequestHistories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeaveTypeHistories",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameOfLeave = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    NoOfDays = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveTypeHistories", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeMemberHistories");

            migrationBuilder.DropTable(
                name: "LeaveBalanceHistories");

            migrationBuilder.DropTable(
                name: "LeaveRequestHistories");

            migrationBuilder.DropTable(
                name: "LeaveTypeHistories");
        }
    }
}
