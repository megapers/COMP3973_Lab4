using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab4COM3773.Migrations
{
    public partial class AddedSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "CityId", "CityName", "Population", "ProvinceCode", "ProvinceCode1" },
                values: new object[,]
                {
                    { 7, "Whitehorse", 24000, "YT", null },
                    { 8, "Whitehorse", 1410, "YT", null },
                    { 9, "Faro", 344, "YT", null }
                });

            migrationBuilder.InsertData(
                table: "Province",
                columns: new[] { "ProvinceCode", "ProvinceName" },
                values: new object[] { "YT", "Yukon" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "ProvinceCode",
                keyValue: "YT");
        }
    }
}
