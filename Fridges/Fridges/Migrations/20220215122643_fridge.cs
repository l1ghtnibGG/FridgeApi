using Microsoft.EntityFrameworkCore.Migrations;

namespace Fridges.Migrations
{
    public partial class fridge : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FridgeProducts_Fridges_fridgeId",
                table: "FridgeProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_FridgeProducts_Products_productId",
                table: "FridgeProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_Fridges_FridgeModels_modelId",
                table: "Fridges");

            migrationBuilder.RenameColumn(
                name: "defaultQuantity",
                table: "Products",
                newName: "DefaultQuantity");

            migrationBuilder.RenameColumn(
                name: "productId",
                table: "Products",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "modelId",
                table: "Fridges",
                newName: "ModelId");

            migrationBuilder.RenameColumn(
                name: "fridgeId",
                table: "Fridges",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Fridges_modelId",
                table: "Fridges",
                newName: "IX_Fridges_ModelId");

            migrationBuilder.RenameColumn(
                name: "quantity",
                table: "FridgeProducts",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "productId",
                table: "FridgeProducts",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "fridgeId",
                table: "FridgeProducts",
                newName: "FridgeId");

            migrationBuilder.RenameColumn(
                name: "fridgeProductsId",
                table: "FridgeProducts",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_FridgeProducts_productId",
                table: "FridgeProducts",
                newName: "IX_FridgeProducts_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_FridgeProducts_fridgeId",
                table: "FridgeProducts",
                newName: "IX_FridgeProducts_FridgeId");

            migrationBuilder.RenameColumn(
                name: "year",
                table: "FridgeModels",
                newName: "Year");

            migrationBuilder.RenameColumn(
                name: "fridgeModelId",
                table: "FridgeModels",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FridgeProducts_Fridges_FridgeId",
                table: "FridgeProducts",
                column: "FridgeId",
                principalTable: "Fridges",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FridgeProducts_Products_ProductId",
                table: "FridgeProducts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fridges_FridgeModels_ModelId",
                table: "Fridges",
                column: "ModelId",
                principalTable: "FridgeModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FridgeProducts_Fridges_FridgeId",
                table: "FridgeProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_FridgeProducts_Products_ProductId",
                table: "FridgeProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_Fridges_FridgeModels_ModelId",
                table: "Fridges");

            migrationBuilder.RenameColumn(
                name: "DefaultQuantity",
                table: "Products",
                newName: "defaultQuantity");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Products",
                newName: "productId");

            migrationBuilder.RenameColumn(
                name: "ModelId",
                table: "Fridges",
                newName: "modelId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Fridges",
                newName: "fridgeId");

            migrationBuilder.RenameIndex(
                name: "IX_Fridges_ModelId",
                table: "Fridges",
                newName: "IX_Fridges_modelId");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "FridgeProducts",
                newName: "quantity");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "FridgeProducts",
                newName: "productId");

            migrationBuilder.RenameColumn(
                name: "FridgeId",
                table: "FridgeProducts",
                newName: "fridgeId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "FridgeProducts",
                newName: "fridgeProductsId");

            migrationBuilder.RenameIndex(
                name: "IX_FridgeProducts_ProductId",
                table: "FridgeProducts",
                newName: "IX_FridgeProducts_productId");

            migrationBuilder.RenameIndex(
                name: "IX_FridgeProducts_FridgeId",
                table: "FridgeProducts",
                newName: "IX_FridgeProducts_fridgeId");

            migrationBuilder.RenameColumn(
                name: "Year",
                table: "FridgeModels",
                newName: "year");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "FridgeModels",
                newName: "fridgeModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_FridgeProducts_Fridges_fridgeId",
                table: "FridgeProducts",
                column: "fridgeId",
                principalTable: "Fridges",
                principalColumn: "fridgeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FridgeProducts_Products_productId",
                table: "FridgeProducts",
                column: "productId",
                principalTable: "Products",
                principalColumn: "productId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fridges_FridgeModels_modelId",
                table: "Fridges",
                column: "modelId",
                principalTable: "FridgeModels",
                principalColumn: "fridgeModelId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
