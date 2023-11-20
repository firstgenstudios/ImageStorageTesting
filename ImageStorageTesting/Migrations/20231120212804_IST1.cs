using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ImageStorageTesting.Migrations
{
    /// <inheritdoc />
    public partial class IST1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Department",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "Designation",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "PhotoFileName",
                table: "Profiles");

            migrationBuilder.RenameColumn(
                name: "PhotoPath",
                table: "Profiles",
                newName: "ImgFileName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImgFileName",
                table: "Profiles",
                newName: "PhotoPath");

            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Designation",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhotoFileName",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
