using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Furniking.DAL.Data.Migrations
{
    /// <inheritdoc />
    public partial class addedgalery : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Furnitures_FurnitureId",
                table: "Images");

            migrationBuilder.RenameColumn(
                name: "FurnitureId",
                table: "Images",
                newName: "FurnitureGaleryId");

            migrationBuilder.RenameIndex(
                name: "IX_Images_FurnitureId",
                table: "Images",
                newName: "IX_Images_FurnitureGaleryId");

            migrationBuilder.AlterColumn<int>(
                name: "MainImageId",
                table: "Furnitures",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Galeries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FurnitureId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Galeries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Galeries_Furnitures_FurnitureId",
                        column: x => x.FurnitureId,
                        principalTable: "Furnitures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Galeries_FurnitureGaleryId",
                table: "Images");

            migrationBuilder.DropTable(
                name: "Galeries");

            migrationBuilder.RenameColumn(
                name: "FurnitureGaleryId",
                table: "Images",
                newName: "FurnitureId");

            migrationBuilder.RenameIndex(
                name: "IX_Images_FurnitureGaleryId",
                table: "Images",
                newName: "IX_Images_FurnitureId");

            migrationBuilder.AlterColumn<int>(
                name: "MainImageId",
                table: "Furnitures",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Furnitures_FurnitureId",
                table: "Images",
                column: "FurnitureId",
                principalTable: "Furnitures",
                principalColumn: "Id");
        }
    }
}
