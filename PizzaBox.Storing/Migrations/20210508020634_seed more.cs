using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Storing.Migrations
{
    public partial class seedmore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "EntityID",
                keyValue: 1L,
                column: "Price",
                value: 7.5);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "EntityID",
                keyValue: 2L,
                column: "Price",
                value: 9.5);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "EntityID",
                keyValue: 3L,
                column: "Price",
                value: 11.5);

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityID",
                keyValue: 1L,
                column: "Name",
                value: "Cheese");

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityID",
                keyValue: 2L,
                column: "Name",
                value: "Bacon");

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityID",
                keyValue: 4L,
                column: "Name",
                value: "Mushroom");

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityID",
                keyValue: 5L,
                column: "Name",
                value: "Beef");

            migrationBuilder.InsertData(
                table: "Toppings",
                columns: new[] { "EntityID", "Name", "Price" },
                values: new object[,]
                {
                    { 6L, "Spinach", 1.5 },
                    { 7L, "Pepperoni", 1.5 },
                    { 8L, "Olives", 1.5 },
                    { 9L, "Sauce", 1.5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "EntityID",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "EntityID",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "EntityID",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "EntityID",
                keyValue: 9L);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "EntityID",
                keyValue: 1L,
                column: "Price",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "EntityID",
                keyValue: 2L,
                column: "Price",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "EntityID",
                keyValue: 3L,
                column: "Price",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityID",
                keyValue: 1L,
                column: "Name",
                value: "Green Peppers");

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityID",
                keyValue: 2L,
                column: "Name",
                value: "Pineapple");

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityID",
                keyValue: 4L,
                column: "Name",
                value: "Cheese");

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityID",
                keyValue: 5L,
                column: "Name",
                value: "Black olives");
        }
    }
}
