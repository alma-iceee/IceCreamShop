using Microsoft.EntityFrameworkCore.Migrations;

namespace IceCreamShop.Migrations
{
    public partial class Change : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IceCreams_Companies_CompanyId",
                table: "IceCreams");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropIndex(
                name: "IX_IceCreams_CompanyId",
                table: "IceCreams");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "IceCreams");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "IceCreams");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "IceCreams");

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerIceCream",
                columns: table => new
                {
                    CustomersId = table.Column<int>(type: "int", nullable: false),
                    IceCreamsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerIceCream", x => new { x.CustomersId, x.IceCreamsId });
                    table.ForeignKey(
                        name: "FK_CustomerIceCream_Customers_CustomersId",
                        column: x => x.CustomersId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerIceCream_IceCreams_IceCreamsId",
                        column: x => x.IceCreamsId,
                        principalTable: "IceCreams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerIceCream_IceCreamsId",
                table: "CustomerIceCream",
                column: "IceCreamsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerIceCream");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "IceCreams",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "IceCreams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "IceCreams",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IceCreams_CompanyId",
                table: "IceCreams",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_IceCreams_Companies_CompanyId",
                table: "IceCreams",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
