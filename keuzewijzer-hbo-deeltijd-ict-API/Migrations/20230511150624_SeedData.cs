using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace keuzewijzer_hbo_deeltijd_ict_API.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "Users",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7736087c-0675-4b4b-9e49-cd3ba7dfea25", "AQAAAAEAACcQAAAAEOOQO9f0teVFgj30HT0bdgdRy8J+PoyKm19+0dmPdzoow9cjkZ6J9EUEwoD/1QzzOw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9a8bc443-819f-40db-b88a-92bf83406e5c", "AQAAAAEAACcQAAAAENWbK8jAUuSFcdJXFrb0SnR6r19JBTupHvbGdqiIPXMntOS8SgzN2pY67PSnTWbe5A==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CohortModules",
                keyColumns: new[] { "CohortsId", "ModulesId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "CohortModules",
                keyColumns: new[] { "CohortsId", "ModulesId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "CohortModules",
                keyColumns: new[] { "CohortsId", "ModulesId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "CohortModules",
                keyColumns: new[] { "CohortsId", "ModulesId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "CohortModules",
                keyColumns: new[] { "CohortsId", "ModulesId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "CohortModules",
                keyColumns: new[] { "CohortsId", "ModulesId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "CohortModules",
                keyColumns: new[] { "CohortsId", "ModulesId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "CohortModules",
                keyColumns: new[] { "CohortsId", "ModulesId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "488f7bc5-42af-4eff-9214-e10caf77f9ee", "AQAAAAEAACcQAAAAEKVoB2cifZWBzMktsVOF7N1FhQjBxow1tqkxDg1PR0OYkoAtKL96Pj6VDFxID544+Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c802f42d-7f05-46f8-b65a-18897ad6ad93", "AQAAAAEAACcQAAAAEG5wxJAdGaMe74SDvDsnUF+3XmdrFaXirYeyKK/lvRhxsA/pr2myXHyXBzdTHF8VUg==" });
        }
    }
}
