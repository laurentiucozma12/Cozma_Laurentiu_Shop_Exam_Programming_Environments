using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlanteeaShop.Migrations
{
    public partial class ProductOrigin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductOriginID",
                table: "Product",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProductOrigin",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OriginName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductOrigin", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductOriginID",
                table: "Product",
                column: "ProductOriginID");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_ProductOrigin_ProductOriginID",
                table: "Product",
                column: "ProductOriginID",
                principalTable: "ProductOrigin",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_ProductOrigin_ProductOriginID",
                table: "Product");

            migrationBuilder.DropTable(
                name: "ProductOrigin");

            migrationBuilder.DropIndex(
                name: "IX_Product_ProductOriginID",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ProductOriginID",
                table: "Product");
        }
    }
}
