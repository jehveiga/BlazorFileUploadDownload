using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorFileUploadDownload.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nome = table.Column<string>(type: "TEXT", nullable: true),
                    preco = table.Column<decimal>(type: "decimal(7, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "id", "nome", "preco" },
                values: new object[,]
                {
                    { 1, "Assassin's Creed", 135m },
                    { 2, "FallOut 4", 155m },
                    { 3, "BordeLands", 195m },
                    { 4, "Duke Nukem", 58m },
                    { 5, "Maria Cart Deluxe 8", 350m },
                    { 6, "Castlevania", 35m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
