using Microsoft.EntityFrameworkCore.Migrations;

namespace Bai2.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "productBai2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    price = table.Column<double>(type: "float", nullable: false),
                    category = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    availibility = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    descriptions = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    imageProduct = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productBai2", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "productBai2");
        }
    }
}
