using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Furniking.DAL.Data.Migrations
{
    /// <inheritdoc />
    public partial class editgalery : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Galeries_FurnitureGaleryId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_FurnitureGaleryId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "FurnitureGaleryId",
                table: "Images");

            migrationBuilder.AddColumn<int>(
                name: "ImageId",
                table: "Galeries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Galeries_ImageId",
                table: "Galeries",
                column: "ImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Galeries_Images_ImageId",
                table: "Galeries",
                column: "ImageId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Galeries_Images_ImageId",
                table: "Galeries");

            migrationBuilder.DropIndex(
                name: "IX_Galeries_ImageId",
                table: "Galeries");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "Galeries");

            migrationBuilder.AddColumn<int>(
                name: "FurnitureGaleryId",
                table: "Images",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Images_FurnitureGaleryId",
                table: "Images",
                column: "FurnitureGaleryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Galeries_FurnitureGaleryId",
                table: "Images",
                column: "FurnitureGaleryId",
                principalTable: "Galeries",
                principalColumn: "Id");
        }
    }
}
