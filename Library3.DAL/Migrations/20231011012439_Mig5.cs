using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library3.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Mig5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PublishYear",
                table: "Publishers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 11, 4, 24, 39, 244, DateTimeKind.Local).AddTicks(5754),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 23, 16, 38, 218, DateTimeKind.Local).AddTicks(2887));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Readers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 11, 4, 24, 39, 244, DateTimeKind.Local).AddTicks(3626),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 23, 16, 38, 218, DateTimeKind.Local).AddTicks(862));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Publishers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 11, 4, 24, 39, 244, DateTimeKind.Local).AddTicks(1662),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 23, 16, 38, 217, DateTimeKind.Local).AddTicks(9017));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 11, 4, 24, 39, 243, DateTimeKind.Local).AddTicks(9681),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 23, 16, 38, 217, DateTimeKind.Local).AddTicks(7015));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReturnDate",
                table: "Books",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReserveDate",
                table: "Books",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                table: "Books",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 11, 4, 24, 39, 243, DateTimeKind.Local).AddTicks(3443),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 10, 23, 16, 38, 217, DateTimeKind.Local).AddTicks(594));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 23, 16, 38, 218, DateTimeKind.Local).AddTicks(2887),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 11, 4, 24, 39, 244, DateTimeKind.Local).AddTicks(5754));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Readers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 23, 16, 38, 218, DateTimeKind.Local).AddTicks(862),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 11, 4, 24, 39, 244, DateTimeKind.Local).AddTicks(3626));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Publishers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 23, 16, 38, 217, DateTimeKind.Local).AddTicks(9017),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 11, 4, 24, 39, 244, DateTimeKind.Local).AddTicks(1662));

            migrationBuilder.AddColumn<string>(
                name: "PublishYear",
                table: "Publishers",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 23, 16, 38, 217, DateTimeKind.Local).AddTicks(7015),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 11, 4, 24, 39, 243, DateTimeKind.Local).AddTicks(9681));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReturnDate",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReserveDate",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 10, 23, 16, 38, 217, DateTimeKind.Local).AddTicks(594),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 11, 4, 24, 39, 243, DateTimeKind.Local).AddTicks(3443));
        }
    }
}
