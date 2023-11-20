using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ImageStorageTesting.Migrations
{
    /// <inheritdoc />
    public partial class IST2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImgData",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgData",
                table: "Profiles");
        }
    }
}
