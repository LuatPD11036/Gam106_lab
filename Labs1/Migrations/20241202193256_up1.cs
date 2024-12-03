using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labs1.Migrations
{
    /// <inheritdoc />
    public partial class up1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "QuizResultId",
                table: "LevelResults",
                newName: "QuizzResultId");

            migrationBuilder.RenameColumn(
                name: "Avartar",
                table: "AspNetUsers",
                newName: "Avatar");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "QuizzResultId",
                table: "LevelResults",
                newName: "QuizResultId");

            migrationBuilder.RenameColumn(
                name: "Avatar",
                table: "AspNetUsers",
                newName: "Avartar");
        }
    }
}
