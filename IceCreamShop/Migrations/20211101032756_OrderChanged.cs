using Microsoft.EntityFrameworkCore.Migrations;

namespace IceCreamShop.Migrations
{
    public partial class OrderChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Goods_GoodsStatuses_StatusId",
                table: "Goods");

            migrationBuilder.DropForeignKey(
                name: "FK_Goods_Products_ProductId",
                table: "Goods");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Goods_StatusId",
                table: "Goods");

            migrationBuilder.DropColumn(
                name: "Company",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "GoodsCode",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Goods");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GoodsId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Goods",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GoodsStatusId",
                table: "Goods",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CompanyId",
                table: "Products",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_GoodsId",
                table: "Orders",
                column: "GoodsId");

            migrationBuilder.CreateIndex(
                name: "IX_Goods_GoodsStatusId",
                table: "Goods",
                column: "GoodsStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Goods_GoodsStatuses_GoodsStatusId",
                table: "Goods",
                column: "GoodsStatusId",
                principalTable: "GoodsStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Goods_Products_ProductId",
                table: "Goods",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Goods_GoodsId",
                table: "Orders",
                column: "GoodsId",
                principalTable: "Goods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Companies_CompanyId",
                table: "Products",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Goods_GoodsStatuses_GoodsStatusId",
                table: "Goods");

            migrationBuilder.DropForeignKey(
                name: "FK_Goods_Products_ProductId",
                table: "Goods");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Goods_GoodsId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Companies_CompanyId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CompanyId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Orders_GoodsId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Goods_GoodsStatusId",
                table: "Goods");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "GoodsId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "GoodsStatusId",
                table: "Goods");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Company",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GoodsCode",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Goods",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "Goods",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Goods_StatusId",
                table: "Goods",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Goods_GoodsStatuses_StatusId",
                table: "Goods",
                column: "StatusId",
                principalTable: "GoodsStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Goods_Products_ProductId",
                table: "Goods",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
