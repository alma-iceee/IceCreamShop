using Microsoft.EntityFrameworkCore.Migrations;

namespace IceCreamShop.Migrations
{
    public partial class AddForegi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IceCreams_Companies_CompanyId",
                table: "IceCreams");

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                table: "IceCreams",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_IceCreams_Companies_CompanyId",
                table: "IceCreams",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IceCreams_Companies_CompanyId",
                table: "IceCreams");

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                table: "IceCreams",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_IceCreams_Companies_CompanyId",
                table: "IceCreams",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
