using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class user : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreateAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "CustomIdentityUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    Mobile = table.Column<long>(type: "bigint", nullable: false),
                    PhotoFileName = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    BrithDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastVisitDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsEmailPublic = table.Column<bool>(type: "bit", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LoginCount = table.Column<int>(type: "int", nullable: false),
                    PurchasedNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomIdentityUsers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "CustomIdentityUsers",
                columns: new[] { "Id", "BrithDate", "CreateAt", "FirstName", "IsActive", "IsEmailPublic", "LastName", "LastVisitDateTime", "Location", "LoginCount", "Mobile", "PhotoFileName", "PurchasedNumber" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2020, 12, 21, 21, 5, 9, 604, DateTimeKind.Unspecified).AddTicks(8735), new TimeSpan(0, 3, 30, 0, 0)), new DateTime(2020, 12, 21, 21, 5, 9, 604, DateTimeKind.Local).AddTicks(5450), "ali", true, true, "nouri", new DateTimeOffset(new DateTime(2020, 12, 21, 21, 5, 9, 605, DateTimeKind.Unspecified).AddTicks(3462), new TimeSpan(0, 3, 30, 0, 0)), "", 1, 0L, "", 0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Body", "CreateAt", "FilePath", "ImagePath", "IsDeleted", "IsSallable", "IsVisible", "Price", "ProductCategoryId", "Title" },
                values: new object[] { 4, "body", new DateTime(2020, 12, 21, 21, 5, 9, 596, DateTimeKind.Local).AddTicks(5756), "File", "Image", false, true, true, 10m, (short)1, "Title" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomIdentityUsers");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "CreateAt",
                table: "Orders");
        }
    }
}
