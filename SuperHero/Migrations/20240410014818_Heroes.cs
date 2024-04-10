using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SuperHero.Migrations
{
    /// <inheritdoc />
    public partial class Heroes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Heroes",
                columns: new[] { "Id", "Description", "Name", "Title" },
                values: new object[,]
                {
                    { 1, "A boy who lost his parent and choose the path of vengence", "Bruce Wayne", "Batman" },
                    { 2, "A friendly neighbourhood", "Peter Parker", "Spider-man" },
                    { 3, "A Techie save the world by creating suit", "Tony Stark", "Iron-man" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
