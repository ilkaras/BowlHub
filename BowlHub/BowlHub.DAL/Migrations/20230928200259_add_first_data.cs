using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BowlHub.DAL.Migrations
{
    /// <inheritdoc />
    public partial class add_first_data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "AdminPhone", "Adress", "City", "Name" },
                values: new object[] { new Guid("65641779-355f-40e4-a1cc-f1e74b3379b0"), "+380 (66) 666-66-66", "Kropyvnytskogo 7", "Kropyvnytskyi", "Sharaga" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: new Guid("65641779-355f-40e4-a1cc-f1e74b3379b0"));
        }
    }
}
