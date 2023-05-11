using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace keuzewijzer_hbo_deeltijd_ict_API.Migrations
{
    public partial class SeedDataModule : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "Users",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ab766552-63ac-45b1-bbd9-8ba252e95013", "AQAAAAEAACcQAAAAEJTia2cnVF5FvCYUMaECyASuW2wzSv6Sv4tVyuvOBlePl3RQcSCY83YIRcWpnxXTXw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "300d74fc-c5cf-4bdf-b11f-23f421bb5363", "AQAAAAEAACcQAAAAEEzab9YGkHAyzrwCQNrG1AWJNK/vh15UKS7KVgEObDt0rhlTUiWp4Dd4oFvnUCWcZA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ModuleRelationships",
                keyColumns: new[] { "DependentModulesId", "RequiredModulesId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "ModuleRelationships",
                keyColumns: new[] { "DependentModulesId", "RequiredModulesId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "ModuleRelationships",
                keyColumns: new[] { "DependentModulesId", "RequiredModulesId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "ModuleRelationships",
                keyColumns: new[] { "DependentModulesId", "RequiredModulesId" },
                keyValues: new object[] { 4, 3 });

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
    }
}
