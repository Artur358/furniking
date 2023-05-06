using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Furniking.DAL.Data.Migrations
{
    /// <inheritdoc />
    public partial class mainImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MainImageId",
                table: "Furnitures",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MainImageId",
                table: "Furnitures");
        }
    }
}
