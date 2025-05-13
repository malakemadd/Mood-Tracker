using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFProject.Migrations
{
    /// <inheritdoc />
    public partial class recommendations2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MoodId",
                table: "Reminders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Reminders_MoodId",
                table: "Reminders",
                column: "MoodId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reminders_Mood_MoodId",
                table: "Reminders",
                column: "MoodId",
                principalTable: "Mood",
                principalColumn: "MoodId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reminders_Mood_MoodId",
                table: "Reminders");

            migrationBuilder.DropIndex(
                name: "IX_Reminders_MoodId",
                table: "Reminders");

            migrationBuilder.DropColumn(
                name: "MoodId",
                table: "Reminders");
        }
    }
}
