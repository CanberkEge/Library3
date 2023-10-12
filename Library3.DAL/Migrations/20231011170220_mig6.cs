using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library3.DAL.Migrations
{
    /// <inheritdoc />
    public partial class mig6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 11, 20, 2, 19, 927, DateTimeKind.Local).AddTicks(7339),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 11, 4, 24, 39, 244, DateTimeKind.Local).AddTicks(5754));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Readers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 11, 20, 2, 19, 927, DateTimeKind.Local).AddTicks(5283),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 11, 4, 24, 39, 244, DateTimeKind.Local).AddTicks(3626));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Publishers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 11, 20, 2, 19, 927, DateTimeKind.Local).AddTicks(3436),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 11, 4, 24, 39, 244, DateTimeKind.Local).AddTicks(1662));

            migrationBuilder.AddColumn<DateTime>(
                name: "PublishYear",
                table: "Publishers",
                type: "datetime2",
                maxLength: 4,
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 11, 20, 2, 19, 927, DateTimeKind.Local).AddTicks(1530),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 11, 4, 24, 39, 243, DateTimeKind.Local).AddTicks(9681));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 11, 20, 2, 19, 926, DateTimeKind.Local).AddTicks(5591),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 11, 4, 24, 39, 243, DateTimeKind.Local).AddTicks(3443));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                oldDefaultValue: new DateTime(2023, 10, 11, 20, 2, 19, 927, DateTimeKind.Local).AddTicks(7339));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Readers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 11, 4, 24, 39, 244, DateTimeKind.Local).AddTicks(3626),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 11, 20, 2, 19, 927, DateTimeKind.Local).AddTicks(5283));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Publishers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 11, 4, 24, 39, 244, DateTimeKind.Local).AddTicks(1662),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 11, 20, 2, 19, 927, DateTimeKind.Local).AddTicks(3436));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 11, 4, 24, 39, 243, DateTimeKind.Local).AddTicks(9681),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 11, 20, 2, 19, 927, DateTimeKind.Local).AddTicks(1530));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 11, 4, 24, 39, 243, DateTimeKind.Local).AddTicks(3443),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 11, 20, 2, 19, 926, DateTimeKind.Local).AddTicks(5591));
        }
    }
}
