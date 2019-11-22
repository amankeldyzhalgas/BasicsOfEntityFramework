using Microsoft.EntityFrameworkCore.Migrations;

namespace BasicsOfEntityFramework.Domain.Migrations
{
    public partial class AddedInitialCommentData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CustomerId", "ProductId", "Text" },
                values: new object[,]
                {
                    { 1, 1, 1, "4" },
                    { 2, 2, 1, "4" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Price", "ProductName", "Quantity", "SellerId" },
                values: new object[,]
                {
                    { 2, "Mouse Delux", 4000m, "Mouse", 4, 1 },
                    { 3, "Monitor Philips", 20000m, "Monitor", 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CustomerId", "ProductId", "Text" },
                values: new object[] { 3, 2, 2, "5" });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CustomerId", "ProductId", "Text" },
                values: new object[] { 4, 2, 2, "4+" });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CustomerId", "ProductId", "Text" },
                values: new object[] { 5, 1, 3, "5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
