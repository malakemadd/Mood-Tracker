using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFProject.Migrations
{
    /// <inheritdoc />
    public partial class deletefk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Mood_MoodId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_MoodId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "MoodId",
                table: "User");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MoodId",
                table: "User",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_MoodId",
                table: "User",
                column: "MoodId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Mood_MoodId",
                table: "User",
                column: "MoodId",
                principalTable: "Mood",
                principalColumn: "MoodId");
        }
    }
}
