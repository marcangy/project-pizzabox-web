using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Storing.Migrations
{
    public partial class addtoppingrel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Toppings_ToppingEntityID",
                table: "Pizzas");

            migrationBuilder.DropForeignKey(
                name: "FK_Toppings_Pizzas_APizzaEntityID",
                table: "Toppings");

            migrationBuilder.DropIndex(
                name: "IX_Toppings_APizzaEntityID",
                table: "Toppings");

            migrationBuilder.DropIndex(
                name: "IX_Pizzas_ToppingEntityID",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "APizzaEntityID",
                table: "Toppings");

            migrationBuilder.DropColumn(
                name: "ToppingEntityID",
                table: "Pizzas");

            migrationBuilder.CreateTable(
                name: "APizzaTopping",
                columns: table => new
                {
                    ToppingsEntityID = table.Column<long>(type: "bigint", nullable: false),
                    pizzasEntityID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_APizzaTopping", x => new { x.ToppingsEntityID, x.pizzasEntityID });
                    table.ForeignKey(
                        name: "FK_APizzaTopping_Pizzas_pizzasEntityID",
                        column: x => x.pizzasEntityID,
                        principalTable: "Pizzas",
                        principalColumn: "EntityID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_APizzaTopping_Toppings_ToppingsEntityID",
                        column: x => x.ToppingsEntityID,
                        principalTable: "Toppings",
                        principalColumn: "EntityID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_APizzaTopping_pizzasEntityID",
                table: "APizzaTopping",
                column: "pizzasEntityID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "APizzaTopping");

            migrationBuilder.AddColumn<long>(
                name: "APizzaEntityID",
                table: "Toppings",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ToppingEntityID",
                table: "Pizzas",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Toppings_APizzaEntityID",
                table: "Toppings",
                column: "APizzaEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_ToppingEntityID",
                table: "Pizzas",
                column: "ToppingEntityID");

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Toppings_ToppingEntityID",
                table: "Pizzas",
                column: "ToppingEntityID",
                principalTable: "Toppings",
                principalColumn: "EntityID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Toppings_Pizzas_APizzaEntityID",
                table: "Toppings",
                column: "APizzaEntityID",
                principalTable: "Pizzas",
                principalColumn: "EntityID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
