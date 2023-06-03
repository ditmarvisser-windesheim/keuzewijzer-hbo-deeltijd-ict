using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace keuzewijzer_hbo_deeltijd_ict_API.Migrations
{
    public partial class new_user_roles_ID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudyRoutes_Users_UserId",
                table: "StudyRoutes");

            migrationBuilder.DropForeignKey(
                name: "FK_UserSemesterItems_Users_UsersId",
                table: "UserSemesterItems");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.AddColumn<int>(
                name: "CohortId1",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "TimedOut",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "ff36f47d-bff2-4ade-8ca0-7e35c32c0511");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "55495650-8b81-4698-bc79-c26e98b96b46");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "e6dfc6f2-4e5d-404e-b0e0-103063a3d482");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "04e2d1a4-79c3-49c8-8860-1cff0a63ca52");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CohortId1", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TimedOut", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, null, "5712bc34-bc03-41ae-95de-71fd4f26e7bc", "admin@example.com", false, "Arnold", "Min", false, null, "Arnold Dirk Min", "admin@example.com", "admin", "AQAAAAEAACcQAAAAELWe4wMd2zNm6F7qHcroXPnCp8HW3ZGQxs73z9FiN6zezi1ksNcI4zMtKfEqpMJ+og==", null, false, null, null, false, "admin" },
                    { "2", 0, null, "8a1d3cbf-0270-4acc-ad7e-1f187e422003", "eugenevanroden@example.com", false, "Eugene", "Van Roden", false, null, "Eugene Van Roden", "eugenevanroden@example.com", "eugenevanroden", "AQAAAAEAACcQAAAAEFlsO3ORsSSy5EpeK9uj+H+hULGbCjW+XRMvtVV+Tfr/TJmNR6YVWpYwd9kCGf0rTw==", null, false, null, null, false, "eugenevanroden" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "1" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CohortId1",
                table: "AspNetUsers",
                column: "CohortId1");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Cohorts_CohortId1",
                table: "AspNetUsers",
                column: "CohortId1",
                principalTable: "Cohorts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StudyRoutes_AspNetUsers_UserId",
                table: "StudyRoutes",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserSemesterItems_AspNetUsers_UsersId",
                table: "UserSemesterItems",
                column: "UsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Cohorts_CohortId1",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_StudyRoutes_AspNetUsers_UserId",
                table: "StudyRoutes");

            migrationBuilder.DropForeignKey(
                name: "FK_UserSemesterItems_AspNetUsers_UsersId",
                table: "UserSemesterItems");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CohortId1",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DropColumn(
                name: "CohortId1",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TimedOut",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CohortId1 = table.Column<int>(type: "int", nullable: true),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimedOut = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Cohorts_CohortId1",
                        column: x => x.CohortId1,
                        principalTable: "Cohorts",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "8917f48d-c53f-4a9e-941b-80e6e1be0dae");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "e6f9d5ec-f0cb-4408-8b4b-818a93d18daa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "9003c939-a544-4eb1-a7e0-4e17ffc76a67");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "dff6f600-8fd3-4a0e-805c-dddf5f31fff0");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "CohortId1", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TimedOut", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, null, "7622303f-3137-4b17-8c2c-aa5b29f7ba9f", "admin@example.com", false, "Arnold", "Min", false, null, "Arnold Dirk Min", "admin@example.com", "admin", "AQAAAAEAACcQAAAAEIQtHSFqKWuZwEKYvQtWnnMk/a5uW9TALvLql23HWc/M5lknLLCNBCWxGOkyIiFKGw==", null, false, null, null, false, "admin" },
                    { "2", 0, null, "9f34a510-a48d-463f-9eff-6fd0bb03765e", "eugenevanroden@example.com", false, "Eugene", "Van Roden", false, null, "Eugene Van Roden", "eugenevanroden@example.com", "eugenevanroden", "AQAAAAEAACcQAAAAEBEmKHdHznSDOzt84HRGfaKk2TZwQYfTt0FbexbWZrXhcrMET5BL1eSXxnn8G6ZXFw==", null, false, null, null, false, "eugenevanroden" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_CohortId1",
                table: "Users",
                column: "CohortId1");

            migrationBuilder.AddForeignKey(
                name: "FK_StudyRoutes_Users_UserId",
                table: "StudyRoutes",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserSemesterItems_Users_UsersId",
                table: "UserSemesterItems",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
