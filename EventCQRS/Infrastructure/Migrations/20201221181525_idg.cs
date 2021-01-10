using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class idg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateAt",
                table: "OrderItem");

            migrationBuilder.UpdateData(
                table: "CustomIdentityUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BrithDate", "CreateAt", "LastVisitDateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 12, 21, 21, 45, 23, 377, DateTimeKind.Unspecified).AddTicks(699), new TimeSpan(0, 3, 30, 0, 0)), new DateTime(2020, 12, 21, 21, 45, 23, 376, DateTimeKind.Local).AddTicks(5618), new DateTimeOffset(new DateTime(2020, 12, 21, 21, 45, 23, 377, DateTimeKind.Unspecified).AddTicks(7827), new TimeSpan(0, 3, 30, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2020, 12, 21, 21, 45, 23, 364, DateTimeKind.Local).AddTicks(6318));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreateAt",
                table: "OrderItem",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "CustomIdentityUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BrithDate", "CreateAt", "LastVisitDateTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2020, 12, 21, 21, 5, 9, 604, DateTimeKind.Unspecified).AddTicks(8735), new TimeSpan(0, 3, 30, 0, 0)), new DateTime(2020, 12, 21, 21, 5, 9, 604, DateTimeKind.Local).AddTicks(5450), new DateTimeOffset(new DateTime(2020, 12, 21, 21, 5, 9, 605, DateTimeKind.Unspecified).AddTicks(3462), new TimeSpan(0, 3, 30, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2020, 12, 21, 21, 5, 9, 596, DateTimeKind.Local).AddTicks(5756));
        }
    }
}
