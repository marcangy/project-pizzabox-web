using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace PizzaBox.Storing.Migrations
{
    public partial class initialcommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Crusts",
                columns: table => new
                {
                    EntityID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crusts", x => x.EntityID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    EntityID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Discriminator = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.EntityID);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    EntityID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.EntityID);
                });

            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    EntityID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Discriminator = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.EntityID);
                });

            migrationBuilder.CreateTable(
                name: "Toppings",
                columns: table => new
                {
                    EntityID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Toppings", x => x.EntityID);
                });

            migrationBuilder.CreateTable(
                name: "Pizzas",
                columns: table => new
                {
                    EntityID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    SizeEntityID = table.Column<long>(type: "bigint", nullable: true),
                    CrustEntityID = table.Column<long>(type: "bigint", nullable: true),
                    TotalPrice = table.Column<double>(type: "double precision", nullable: false),
                    Discriminator = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pizzas", x => x.EntityID);
                    table.ForeignKey(
                        name: "FK_Pizzas_Crusts_CrustEntityID",
                        column: x => x.CrustEntityID,
                        principalTable: "Crusts",
                        principalColumn: "EntityID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pizzas_Sizes_SizeEntityID",
                        column: x => x.SizeEntityID,
                        principalTable: "Sizes",
                        principalColumn: "EntityID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    EntityID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ID = table.Column<int>(type: "integer", nullable: false),
                    StoreEntityID = table.Column<long>(type: "bigint", nullable: true),
                    CustomerEntityID = table.Column<long>(type: "bigint", nullable: true),
                    ACustomerEntityID = table.Column<long>(type: "bigint", nullable: true),
                    Discriminator = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.EntityID);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_ACustomerEntityID",
                        column: x => x.ACustomerEntityID,
                        principalTable: "Customers",
                        principalColumn: "EntityID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerEntityID",
                        column: x => x.CustomerEntityID,
                        principalTable: "Customers",
                        principalColumn: "EntityID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Stores_StoreEntityID",
                        column: x => x.StoreEntityID,
                        principalTable: "Stores",
                        principalColumn: "EntityID",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateTable(
                name: "AOrderAPizza",
                columns: table => new
                {
                    OrdersEntityID = table.Column<long>(type: "bigint", nullable: false),
                    PizzasEntityID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AOrderAPizza", x => new { x.OrdersEntityID, x.PizzasEntityID });
                    table.ForeignKey(
                        name: "FK_AOrderAPizza_Orders_OrdersEntityID",
                        column: x => x.OrdersEntityID,
                        principalTable: "Orders",
                        principalColumn: "EntityID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AOrderAPizza_Pizzas_PizzasEntityID",
                        column: x => x.PizzasEntityID,
                        principalTable: "Pizzas",
                        principalColumn: "EntityID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "EntityID", "Discriminator", "Name" },
                values: new object[] { 1L, "RegCustomer", "Samual Adams" });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "EntityID", "Discriminator", "Name" },
                values: new object[,]
                {
                    { 1L, "NewYorkStore", "Da Best NY Pizza" },
                    { 2L, "ChicagoStore", "Chitown Pizzeria" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AOrderAPizza_PizzasEntityID",
                table: "AOrderAPizza",
                column: "PizzasEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_APizzaTopping_pizzasEntityID",
                table: "APizzaTopping",
                column: "pizzasEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ACustomerEntityID",
                table: "Orders",
                column: "ACustomerEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerEntityID",
                table: "Orders",
                column: "CustomerEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_StoreEntityID",
                table: "Orders",
                column: "StoreEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_CrustEntityID",
                table: "Pizzas",
                column: "CrustEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_SizeEntityID",
                table: "Pizzas",
                column: "SizeEntityID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AOrderAPizza");

            migrationBuilder.DropTable(
                name: "APizzaTopping");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Pizzas");

            migrationBuilder.DropTable(
                name: "Toppings");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Stores");

            migrationBuilder.DropTable(
                name: "Crusts");

            migrationBuilder.DropTable(
                name: "Sizes");
        }
    }
}
