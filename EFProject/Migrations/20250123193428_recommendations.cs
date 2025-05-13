using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFProject.Migrations
{
    /// <inheritdoc />
    public partial class recommendations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RemindersUser");

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
                name: "resource_link",
                table: "Reminders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "resource_title",
                table: "Reminders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "RecommendationsUser",
                columns: table => new
                {
                    RecommId = table.Column<int>(type: "int", nullable: false),
                    Usersusername = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecommendationsUser", x => new { x.RecommId, x.Usersusername });
                    table.ForeignKey(
                        name: "FK_RecommendationsUser_Reminders_RecommId",
                        column: x => x.RecommId,
                        principalTable: "Reminders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecommendationsUser_User_Usersusername",
                        column: x => x.Usersusername,
                        principalTable: "User",
                        principalColumn: "username",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RecommendationsUser_Usersusername",
                table: "RecommendationsUser",
                column: "Usersusername");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RecommendationsUser");

            migrationBuilder.DropColumn(
                name: "activity",
                table: "Reminders");

            migrationBuilder.DropColumn(
                name: "mood",
                table: "Reminders");

            migrationBuilder.DropColumn(
                name: "resource_link",
                table: "Reminders");

            migrationBuilder.DropColumn(
                name: "resource_title",
                table: "Reminders");

            migrationBuilder.CreateTable(
                name: "RemindersUser",
                columns: table => new
                {
                    RemindersId = table.Column<int>(type: "int", nullable: false),
                    Usersusername = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RemindersUser", x => new { x.RemindersId, x.Usersusername });
                    table.ForeignKey(
                        name: "FK_RemindersUser_Reminders_RemindersId",
                        column: x => x.RemindersId,
                        principalTable: "Reminders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RemindersUser_User_Usersusername",
                        column: x => x.Usersusername,
                        principalTable: "User",
                        principalColumn: "username",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RemindersUser_Usersusername",
                table: "RemindersUser",
                column: "Usersusername");
        }
    }
}
