using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFProject.Migrations
{
    /// <inheritdoc />
    public partial class usermood2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Details",
                table: "Mood");

            migrationBuilder.DropColumn(
                name: "Intensity",
                table: "Mood");

            migrationBuilder.DropColumn(
                name: "MoodDate",
                table: "Mood");

            migrationBuilder.DropColumn(
                name: "Trigger",
                table: "Mood");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Details",
                table: "Mood",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Intensity",
                table: "Mood",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "MoodDate",
                table: "Mood",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Trigger",
                table: "Mood",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
