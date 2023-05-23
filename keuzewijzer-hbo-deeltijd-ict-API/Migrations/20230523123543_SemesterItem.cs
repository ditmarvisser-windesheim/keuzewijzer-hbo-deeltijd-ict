using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace keuzewijzer_hbo_deeltijd_ict_API.Migrations
{
    public partial class SemesterItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudyRouteItems_Modules_ModuleId",
                table: "StudyRouteItems");

            migrationBuilder.DropTable(
                name: "CohortModules");

            migrationBuilder.DropTable(
                name: "ModuleRelationships");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "Semester",
                table: "Modules");

            migrationBuilder.RenameColumn(
                name: "ModuleId",
                table: "StudyRouteItems",
                newName: "SemesterItemId");

            migrationBuilder.RenameIndex(
                name: "IX_StudyRouteItems_ModuleId",
                table: "StudyRouteItems",
                newName: "IX_StudyRouteItems_SemesterItemId");

            migrationBuilder.RenameColumn(
                name: "Year",
                table: "Modules",
                newName: "SemesterItemId");

            migrationBuilder.CreateTable(
                name: "SemesterItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Semester = table.Column<int>(type: "int", nullable: false),
                    StudyRouteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SemesterItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SemesterItems_StudyRoutes_StudyRouteId",
                        column: x => x.StudyRouteId,
                        principalTable: "StudyRoutes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CohortSemesterItems",
                columns: table => new
                {
                    CohortsId = table.Column<int>(type: "int", nullable: false),
                    SemesterItemsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CohortSemesterItems", x => new { x.CohortsId, x.SemesterItemsId });
                    table.ForeignKey(
                        name: "FK_CohortSemesterItems_Cohorts_CohortsId",
                        column: x => x.CohortsId,
                        principalTable: "Cohorts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CohortSemesterItems_SemesterItems_SemesterItemsId",
                        column: x => x.SemesterItemsId,
                        principalTable: "SemesterItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SemesterItemRelationships",
                columns: table => new
                {
                    DependentSemesterItemId = table.Column<int>(type: "int", nullable: false),
                    RequiredSemesterItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SemesterItemRelationships", x => new { x.DependentSemesterItemId, x.RequiredSemesterItemId });
                    table.ForeignKey(
                        name: "FK_SemesterItemRelationships_SemesterItems_DependentSemesterItemId",
                        column: x => x.DependentSemesterItemId,
                        principalTable: "SemesterItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SemesterItemRelationships_SemesterItems_RequiredSemesterItemId",
                        column: x => x.RequiredSemesterItemId,
                        principalTable: "SemesterItems",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Cohorts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Year",
                value: 2020);

            migrationBuilder.UpdateData(
                table: "Cohorts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Year",
                value: 2021);

            migrationBuilder.UpdateData(
                table: "Cohorts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Year",
                value: 2022);

            migrationBuilder.UpdateData(
                table: "Cohorts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Year",
                value: 2023);

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 5,
                column: "SemesterItemId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 6,
                column: "SemesterItemId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 7,
                column: "SemesterItemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 8,
                column: "SemesterItemId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 9,
                column: "SemesterItemId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 10,
                column: "SemesterItemId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 11,
                column: "SemesterItemId",
                value: 11);

            migrationBuilder.InsertData(
                table: "SemesterItems",
                columns: new[] { "Id", "Description", "Name", "Semester", "StudyRouteId", "Year" },
                values: new object[,]
                {
                    { 1, "Description for Semester Item 1", "Semester Item 1", 1, 1, 1 },
                    { 2, "Description for Semester Item 2", "Semester Item 2", 2, 1, 1 },
                    { 3, "Description for Semester Item 3", "Semester Item 3", 1, 1, 2 },
                    { 4, "Description for Semester Item 4", "Semester Item 4", 2, 1, 2 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4d7e497b-48b3-4fd3-8c87-f097b8eb4dba", "AQAAAAEAACcQAAAAEIsrXf4dJLpG/6gzRFfKDpasTr4A8UudXxfRTWqfbNFkP2wIDtCv7ZGvagf5+sBOEQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4252848f-bc8d-476a-a862-cd56b4ba3a32", "AQAAAAEAACcQAAAAEHzECuUBkYqx1PxiWUOT0XS4htlC3FRVfVg1BiLDARna6rmPjN6RSVh7IyXGiBW2tQ==" });

            migrationBuilder.InsertData(
                table: "CohortSemesterItems",
                columns: new[] { "CohortsId", "SemesterItemsId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 3, 4 },
                    { 4, 3 },
                    { 4, 4 }
                });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 1,
                column: "SemesterItemId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 2,
                column: "SemesterItemId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 3,
                column: "SemesterItemId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 4,
                column: "SemesterItemId",
                value: 4);

            migrationBuilder.InsertData(
                table: "SemesterItemRelationships",
                columns: new[] { "DependentSemesterItemId", "RequiredSemesterItemId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 3, 2 },
                    { 4, 1 },
                    { 4, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Modules_SemesterItemId",
                table: "Modules",
                column: "SemesterItemId");

            migrationBuilder.CreateIndex(
                name: "IX_CohortSemesterItems_SemesterItemsId",
                table: "CohortSemesterItems",
                column: "SemesterItemsId");

            migrationBuilder.CreateIndex(
                name: "IX_SemesterItemRelationships_RequiredSemesterItemId",
                table: "SemesterItemRelationships",
                column: "RequiredSemesterItemId");

            migrationBuilder.CreateIndex(
                name: "IX_SemesterItems_StudyRouteId",
                table: "SemesterItems",
                column: "StudyRouteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Modules_SemesterItems_SemesterItemId",
                table: "Modules",
                column: "SemesterItemId",
                principalTable: "SemesterItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudyRouteItems_SemesterItems_SemesterItemId",
                table: "StudyRouteItems",
                column: "SemesterItemId",
                principalTable: "SemesterItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Modules_SemesterItems_SemesterItemId",
                table: "Modules");

            migrationBuilder.DropForeignKey(
                name: "FK_StudyRouteItems_SemesterItems_SemesterItemId",
                table: "StudyRouteItems");

            migrationBuilder.DropTable(
                name: "CohortSemesterItems");

            migrationBuilder.DropTable(
                name: "SemesterItemRelationships");

            migrationBuilder.DropTable(
                name: "SemesterItems");

            migrationBuilder.DropIndex(
                name: "IX_Modules_SemesterItemId",
                table: "Modules");

            migrationBuilder.RenameColumn(
                name: "SemesterItemId",
                table: "StudyRouteItems",
                newName: "ModuleId");

            migrationBuilder.RenameIndex(
                name: "IX_StudyRouteItems_SemesterItemId",
                table: "StudyRouteItems",
                newName: "IX_StudyRouteItems_ModuleId");

            migrationBuilder.RenameColumn(
                name: "SemesterItemId",
                table: "Modules",
                newName: "Year");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Modules",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Semester",
                table: "Modules",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CohortModules",
                columns: table => new
                {
                    CohortsId = table.Column<int>(type: "int", nullable: false),
                    ModulesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CohortModules", x => new { x.CohortsId, x.ModulesId });
                    table.ForeignKey(
                        name: "FK_CohortModules_Cohorts_CohortsId",
                        column: x => x.CohortsId,
                        principalTable: "Cohorts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CohortModules_Modules_ModulesId",
                        column: x => x.ModulesId,
                        principalTable: "Modules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ModuleRelationships",
                columns: table => new
                {
                    DependentModulesId = table.Column<int>(type: "int", nullable: false),
                    RequiredModulesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModuleRelationships", x => new { x.DependentModulesId, x.RequiredModulesId });
                    table.ForeignKey(
                        name: "FK_ModuleRelationships_Modules_DependentModulesId",
                        column: x => x.DependentModulesId,
                        principalTable: "Modules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModuleRelationships_Modules_RequiredModulesId",
                        column: x => x.RequiredModulesId,
                        principalTable: "Modules",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "CohortModules",
                columns: new[] { "CohortsId", "ModulesId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 3, 4 },
                    { 4, 3 },
                    { 4, 4 }
                });

            migrationBuilder.UpdateData(
                table: "Cohorts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Year",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Cohorts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Year",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Cohorts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Year",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Cohorts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Year",
                value: 2);

            migrationBuilder.InsertData(
                table: "ModuleRelationships",
                columns: new[] { "DependentModulesId", "RequiredModulesId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 3, 2 },
                    { 4, 1 },
                    { 4, 3 }
                });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Semester", "Year" },
                values: new object[] { "Description for Module 1", 1, 2013 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Semester", "Year" },
                values: new object[] { "Description for Module 2", 2, 2014 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Semester", "Year" },
                values: new object[] { "Description for Module 3", 1, 2015 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Semester", "Year" },
                values: new object[] { "Description for Module 4", 2, 2016 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Semester", "Year" },
                values: new object[] { "Description for Module 5", 1, 2017 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Semester", "Year" },
                values: new object[] { "Description for Module 6", 2, 2018 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Semester", "Year" },
                values: new object[] { "Description for Module 7", 1, 2019 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Semester", "Year" },
                values: new object[] { "Description for Module 8", 2, 2020 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Semester", "Year" },
                values: new object[] { "Description for Module 9", 1, 2021 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Semester", "Year" },
                values: new object[] { "Description for Module 10", 2, 2022 });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "Semester", "Year" },
                values: new object[] { "Description for Module 11", 2, 2023 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8f1c0471-21da-4ce7-afd9-3c45f772b670", "AQAAAAEAACcQAAAAENextsNiz4T+5/w2dF6BwyJCo2JnqoC6bUmpu5NsyR3h+uDF8vHhwFNkADZJmN1WWg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9d23031c-e838-47e7-9fa8-4a908b03ae33", "AQAAAAEAACcQAAAAEL1jLISit2HaeEXJqIaUxTIQSJK0ZBQBmFnEp7JCDPD233OsD/GzDNSgs8Q4Uwl0dQ==" });

            migrationBuilder.CreateIndex(
                name: "IX_CohortModules_ModulesId",
                table: "CohortModules",
                column: "ModulesId");

            migrationBuilder.CreateIndex(
                name: "IX_ModuleRelationships_RequiredModulesId",
                table: "ModuleRelationships",
                column: "RequiredModulesId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudyRouteItems_Modules_ModuleId",
                table: "StudyRouteItems",
                column: "ModuleId",
                principalTable: "Modules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
