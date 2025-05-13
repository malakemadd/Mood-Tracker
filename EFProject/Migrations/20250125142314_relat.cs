using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFProject.Migrations
{
    /// <inheritdoc />
    public partial class relat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserMoodMoodId",
                table: "Mood",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Mood_UserMoodMoodId",
                table: "Mood",
                column: "UserMoodMoodId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mood_UserMoods_UserMoodMoodId",
                table: "Mood",
                column: "UserMoodMoodId",
                principalTable: "UserMoods",
                principalColumn: "MoodId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mood_UserMoods_UserMoodMoodId",
                table: "Mood");

            migrationBuilder.DropIndex(
                name: "IX_Mood_UserMoodMoodId",
                table: "Mood");

            migrationBuilder.DropColumn(
                name: "UserMoodMoodId",
                table: "Mood");
        }
    }
}
