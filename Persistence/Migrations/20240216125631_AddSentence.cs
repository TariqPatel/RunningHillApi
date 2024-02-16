using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddSentence : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Activities");

            migrationBuilder.RenameColumn(
                name: "Venue",
                table: "Activities",
                newName: "Sentence");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Sentence",
                table: "Activities",
                newName: "Venue");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Activities",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Activities",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Activities",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Activities",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Activities",
                type: "TEXT",
                nullable: true);
        }
    }
}
