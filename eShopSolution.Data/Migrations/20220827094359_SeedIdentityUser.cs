using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 27, 16, 43, 58, 913, DateTimeKind.Local).AddTicks(3866),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 8, 27, 16, 13, 6, 757, DateTimeKind.Local).AddTicks(7922));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("fcac71a7-b477-4770-98fb-bdcc323715cd"), "abfdbcbb-d481-4e2d-9b42-fc3c0f7e0114", "Adminstrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("fcac71a7-b477-4770-98fb-bdcc323715cd"), new Guid("425565be-ca67-4d0d-9124-5c0b370b5848") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("425565be-ca67-4d0d-9124-5c0b370b5848"), 0, "0cad026a-fe34-4825-8a6b-a3ab53706032", new DateTime(1901, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "some-admin-email@nonce.fake", true, "Minh", "Dinh", false, null, "some-admin-email@nonce.fake", "admin", "AQAAAAEAACcQAAAAEK4B+IImqg5Ug7MBjOljhtdbv3h/rzdvi6KziqYXO5Ci8y0khvi8N5hAB09oyHiazw==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCreated",
                value: new DateTime(2022, 8, 27, 16, 43, 58, 931, DateTimeKind.Local).AddTicks(3495));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("fcac71a7-b477-4770-98fb-bdcc323715cd"));

            migrationBuilder.DeleteData(
                table: "AppUserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("fcac71a7-b477-4770-98fb-bdcc323715cd"), new Guid("425565be-ca67-4d0d-9124-5c0b370b5848") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("425565be-ca67-4d0d-9124-5c0b370b5848"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 27, 16, 13, 6, 757, DateTimeKind.Local).AddTicks(7922),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 8, 27, 16, 43, 58, 913, DateTimeKind.Local).AddTicks(3866));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCreated",
                value: new DateTime(2022, 8, 27, 16, 13, 6, 776, DateTimeKind.Local).AddTicks(7210));
        }
    }
}
