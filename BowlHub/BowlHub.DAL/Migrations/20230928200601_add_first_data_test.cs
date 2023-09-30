using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BowlHub.DAL.Migrations
{
    /// <inheritdoc />
    public partial class add_first_data_test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("65641779-355f-40e4-a1cc-f1e74b3379b0"));

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "AdminPhone", "Adress", "City", "Name" },
                values: new object[,]
                {
                    { new Guid("60dc9058-55d3-4a55-9594-a9684a503c5b"), "+380 (66) 666-66-66", "Kropyvnytskogo 7", "Kropyvnytskyi", "Sharaga" },
                    { new Guid("9a946ef3-1d89-4764-9e81-43813bb422c1"), "+380 (66) 666-66-66", "Kropyvnytskogo 7", "Kropyvnytskyi", "Sharaga" },
                    { new Guid("aaa85140-61ee-4e07-9ba8-32733a38442d"), "+380 (66) 666-66-66", "Kropyvnytskogo 7", "Kropyvnytskyi", "Sharaga" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("60dc9058-55d3-4a55-9594-a9684a503c5b"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("9a946ef3-1d89-4764-9e81-43813bb422c1"));

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("aaa85140-61ee-4e07-9ba8-32733a38442d"));

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "AdminPhone", "Adress", "City", "Name" },
                values: new object[] { new Guid("65641779-355f-40e4-a1cc-f1e74b3379b0"), "+380 (66) 666-66-66", "Kropyvnytskogo 7", "Kropyvnytskyi", "Sharaga" });
        }
    }
}
