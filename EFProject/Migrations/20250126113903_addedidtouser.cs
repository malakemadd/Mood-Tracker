using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFProject.Migrations
{
    /// <inheritdoc />
    public partial class addedidtouser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RecommendationsUser_User_Usersusername",
                table: "RecommendationsUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RecommendationsUser",
                table: "RecommendationsUser");

            migrationBuilder.DropIndex(
                name: "IX_RecommendationsUser_Usersusername",
                table: "RecommendationsUser");

            migrationBuilder.DropColumn(
                name: "Usersusername",
                table: "RecommendationsUser");

            migrationBuilder.AlterColumn<string>(
                name: "username",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "UsersId",
                table: "RecommendationsUser",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RecommendationsUser",
                table: "RecommendationsUser",
                columns: new[] { "RecommId", "UsersId" });

            migrationBuilder.CreateIndex(
                name: "IX_RecommendationsUser_UsersId",
                table: "RecommendationsUser",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_RecommendationsUser_User_UsersId",
                table: "RecommendationsUser",
                column: "UsersId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RecommendationsUser_User_UsersId",
                table: "RecommendationsUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RecommendationsUser",
                table: "RecommendationsUser");

            migrationBuilder.DropIndex(
                name: "IX_RecommendationsUser_UsersId",
                table: "RecommendationsUser");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "User");

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "RecommendationsUser");

            migrationBuilder.AlterColumn<string>(
                name: "username",
                table: "User",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Usersusername",
                table: "RecommendationsUser",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "username");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RecommendationsUser",
                table: "RecommendationsUser",
                columns: new[] { "RecommId", "Usersusername" });

            migrationBuilder.CreateIndex(
                name: "IX_RecommendationsUser_Usersusername",
                table: "RecommendationsUser",
                column: "Usersusername");

            migrationBuilder.AddForeignKey(
                name: "FK_RecommendationsUser_User_Usersusername",
                table: "RecommendationsUser",
                column: "Usersusername",
                principalTable: "User",
                principalColumn: "username",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
