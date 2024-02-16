using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataMigration.Migrations
{
    public partial class BaseEntityAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NameOfLeave",
                table: "LeaveTypeHistories");

            migrationBuilder.DropColumn(
                name: "DateOfLastAction",
                table: "LeaveRequestHistories");

            migrationBuilder.DropColumn(
                name: "DateOfRequest",
                table: "LeaveRequestHistories");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "LeaveRequestHistories");

            migrationBuilder.DropColumn(
                name: "LeaveType",
                table: "LeaveBalanceHistories");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "LeaveTypeHistories",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "LeaveBalanceHistories",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "NoOfDays",
                table: "LeaveTypeHistories",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveTypeHistories",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "LeaveTypeHistories",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveTypeHistories",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeId",
                table: "LeaveRequestHistories",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveRequestHistories",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "LeaveStatus",
                table: "LeaveRequestHistories",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveRequestHistories",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveBalanceHistories",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "LeaveTypeId",
                table: "LeaveBalanceHistories",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveBalanceHistories",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "EmployeeMemberHistories",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "EmployeeMemberHistories",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "EmployeeMemberHistories",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeId",
                table: "EmployeeMemberHistories",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "EmployeeMemberHistories",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "EmployeeMemberHistories",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmployeeMemberHistories",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "LeaveTypeHistories");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "LeaveTypeHistories");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "LeaveTypeHistories");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "LeaveRequestHistories");

            migrationBuilder.DropColumn(
                name: "LeaveStatus",
                table: "LeaveRequestHistories");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "LeaveRequestHistories");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "LeaveBalanceHistories");

            migrationBuilder.DropColumn(
                name: "LeaveTypeId",
                table: "LeaveBalanceHistories");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "LeaveBalanceHistories");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "EmployeeMemberHistories");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "EmployeeMemberHistories");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "LeaveTypeHistories",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "LeaveBalanceHistories",
                newName: "id");

            migrationBuilder.AlterColumn<string>(
                name: "NoOfDays",
                table: "LeaveTypeHistories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "NameOfLeave",
                table: "LeaveTypeHistories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "LeaveRequestHistories",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfLastAction",
                table: "LeaveRequestHistories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfRequest",
                table: "LeaveRequestHistories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "LeaveRequestHistories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LeaveType",
                table: "LeaveBalanceHistories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PhoneNumber",
                table: "EmployeeMemberHistories",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "EmployeeMemberHistories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "EmployeeMemberHistories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "EmployeeMemberHistories",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "EmployeeMemberHistories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);
        }
    }
}
