using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Furniking.DAL.Data.Migrations
{
    /// <inheritdoc />
    public partial class editfurniture : Migration
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

            migrationBuilder.DropIndex(
                name: "IX_Galeries_FurnitureId",
                table: "Galeries");

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
                name: "IX_Galeries_FurnitureId",
                table: "Galeries",
                column: "FurnitureId");

            migrationBuilder.CreateIndex(
                name: "IX_Galeries_ImageId",
                table: "Galeries",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Furnitures_MainImageId",
                table: "Furnitures",
                column: "MainImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Furnitures_Images_MainImageId",
                table: "Furnitures",
                column: "MainImageId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Galeries_Images_ImageId",
                table: "Galeries",
                column: "ImageId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Furnitures_Images_MainImageId",
                table: "Furnitures");

            migrationBuilder.DropForeignKey(
                name: "FK_Galeries_Images_ImageId",
                table: "Galeries");

            migrationBuilder.DropIndex(
                name: "IX_Galeries_FurnitureId",
                table: "Galeries");

            migrationBuilder.DropIndex(
                name: "IX_Galeries_ImageId",
                table: "Galeries");

            migrationBuilder.DropIndex(
                name: "IX_Furnitures_MainImageId",
                table: "Furnitures");

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

            migrationBuilder.CreateIndex(
                name: "IX_Galeries_FurnitureId",
                table: "Galeries",
                column: "FurnitureId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Galeries_FurnitureGaleryId",
                table: "Images",
                column: "FurnitureGaleryId",
                principalTable: "Galeries",
                principalColumn: "Id");
        }
    }
}
