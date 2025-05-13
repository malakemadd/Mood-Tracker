using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFProject.Migrations
{
    /// <inheritdoc />
    public partial class recommendations3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RecommendationsUser_Reminders_RecommId",
                table: "RecommendationsUser");

            migrationBuilder.DropForeignKey(
                name: "FK_Reminders_Mood_MoodId",
                table: "Reminders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reminders",
                table: "Reminders");

            migrationBuilder.DropColumn(
                name: "activity",
                table: "Reminders");

            migrationBuilder.DropColumn(
                name: "mood",
                table: "Reminders");

            migrationBuilder.DropColumn(
                name: "reminders",
                table: "Reminders");

            migrationBuilder.DropColumn(
                name: "resource_link",
                table: "Reminders");

            migrationBuilder.RenameTable(
                name: "Reminders",
                newName: "Recommendations");

            migrationBuilder.RenameColumn(
                name: "MoodId",
                table: "Recommendations",
                newName: "moodid");

            migrationBuilder.RenameColumn(
                name: "resource_title",
                table: "Recommendations",
                newName: "recommend");

            migrationBuilder.RenameIndex(
                name: "IX_Reminders_MoodId",
                table: "Recommendations",
                newName: "IX_Recommendations_moodid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Recommendations",
                table: "Recommendations",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Recommendations_Mood_moodid",
                table: "Recommendations",
                column: "moodid",
                principalTable: "Mood",
                principalColumn: "MoodId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RecommendationsUser_Recommendations_RecommId",
                table: "RecommendationsUser",
                column: "RecommId",
                principalTable: "Recommendations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recommendations_Mood_moodid",
                table: "Recommendations");

            migrationBuilder.DropForeignKey(
                name: "FK_RecommendationsUser_Recommendations_RecommId",
                table: "RecommendationsUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Recommendations",
                table: "Recommendations");

            migrationBuilder.RenameTable(
                name: "Recommendations",
                newName: "Reminders");

            migrationBuilder.RenameColumn(
                name: "moodid",
                table: "Reminders",
                newName: "MoodId");

            migrationBuilder.RenameColumn(
                name: "recommend",
                table: "Reminders",
                newName: "resource_title");

            migrationBuilder.RenameIndex(
                name: "IX_Recommendations_moodid",
                table: "Reminders",
                newName: "IX_Reminders_MoodId");

            migrationBuilder.AddColumn<string>(
                name: "activity",
                table: "Reminders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "mood",
                table: "Reminders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "reminders",
                table: "Reminders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "resource_link",
                table: "Reminders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reminders",
                table: "Reminders",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RecommendationsUser_Reminders_RecommId",
                table: "RecommendationsUser",
                column: "RecommId",
                principalTable: "Reminders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reminders_Mood_MoodId",
                table: "Reminders",
                column: "MoodId",
                principalTable: "Mood",
                principalColumn: "MoodId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
