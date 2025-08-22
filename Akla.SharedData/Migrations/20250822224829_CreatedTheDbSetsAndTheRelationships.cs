using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Akla.SharedData.Migrations
{
    /// <inheritdoc />
    public partial class CreatedTheDbSetsAndTheRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    PasswordHashed = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Join_Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Vehicle_Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    License_Plate = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PrimaryPhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MenuCategories",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Ordering = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MenuItems",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Available = table.Column<bool>(type: "bit", nullable: false),
                    Preparation_Time = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethods",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Method_Name = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Promotions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Discount_Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Discount_Value = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Start_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End_Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RestaurantTables",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TableNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    LocationZone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantTables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Street = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Customer_Id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Customers_Customer_Id",
                        column: x => x.Customer_Id,
                        principalTable: "Customers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CustomerPhones",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Customer_Id = table.Column<long>(type: "bigint", nullable: false),
                    Phone_Number = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerPhones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerPhones_Customers_Customer_Id",
                        column: x => x.Customer_Id,
                        principalTable: "Customers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DriverPhones",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Driver_Id = table.Column<long>(type: "bigint", nullable: false),
                    Phone_Number = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriverPhones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DriverPhones_Drivers_Driver_Id",
                        column: x => x.Driver_Id,
                        principalTable: "Drivers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MenuCategoryItems",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuCategory_Id = table.Column<long>(type: "bigint", nullable: false),
                    MenuItem_Id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuCategoryItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MenuCategoryItems_MenuCategories_MenuCategory_Id",
                        column: x => x.MenuCategory_Id,
                        principalTable: "MenuCategories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MenuCategoryItems_MenuItems_MenuItem_Id",
                        column: x => x.MenuItem_Id,
                        principalTable: "MenuItems",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Review_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Customer_Id = table.Column<long>(type: "bigint", nullable: false),
                    MenuItem_Id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Customers_Customer_Id",
                        column: x => x.Customer_Id,
                        principalTable: "Customers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reviews_MenuItems_MenuItem_Id",
                        column: x => x.MenuItem_Id,
                        principalTable: "MenuItems",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Order_Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Total_Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Delivery_Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    PaymentMethod_Id = table.Column<long>(type: "bigint", nullable: false),
                    Customer_Id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_Customer_Id",
                        column: x => x.Customer_Id,
                        principalTable: "Customers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Orders_PaymentMethods_PaymentMethod_Id",
                        column: x => x.PaymentMethod_Id,
                        principalTable: "PaymentMethods",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image_Url = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    MenuItem_Id = table.Column<long>(type: "bigint", nullable: false),
                    Promotion_Id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_MenuItems_MenuItem_Id",
                        column: x => x.MenuItem_Id,
                        principalTable: "MenuItems",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Images_Promotions_Promotion_Id",
                        column: x => x.Promotion_Id,
                        principalTable: "Promotions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MenuItemPromotions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuItem_Id = table.Column<long>(type: "bigint", nullable: false),
                    Promotion_Id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItemPromotions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MenuItemPromotions_MenuItems_MenuItem_Id",
                        column: x => x.MenuItem_Id,
                        principalTable: "MenuItems",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MenuItemPromotions_Promotions_Promotion_Id",
                        column: x => x.Promotion_Id,
                        principalTable: "Promotions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Reservatoin_Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Party_Size = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Special_Requests = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    RestaurantTable_Id = table.Column<long>(type: "bigint", nullable: false),
                    Customer_Id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_Customers_Customer_Id",
                        column: x => x.Customer_Id,
                        principalTable: "Customers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reservations_RestaurantTables_RestaurantTable_Id",
                        column: x => x.RestaurantTable_Id,
                        principalTable: "RestaurantTables",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Deliveries",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Delivery_Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Dispath_Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Driver_Id = table.Column<long>(type: "bigint", nullable: false),
                    Order_Id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deliveries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Deliveries_Drivers_Driver_Id",
                        column: x => x.Driver_Id,
                        principalTable: "Drivers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Deliveries_Orders_Order_Id",
                        column: x => x.Order_Id,
                        principalTable: "Orders",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Unit_Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Special_Instructions = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    MenuItem_Id = table.Column<long>(type: "bigint", nullable: false),
                    Order_Id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_MenuItems_Order_Id",
                        column: x => x.Order_Id,
                        principalTable: "MenuItems",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_Order_Id",
                        column: x => x.Order_Id,
                        principalTable: "Orders",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_Customer_Id",
                table: "Addresses",
                column: "Customer_Id");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerPhones_Customer_Id",
                table: "CustomerPhones",
                column: "Customer_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_Driver_Id",
                table: "Deliveries",
                column: "Driver_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_Order_Id",
                table: "Deliveries",
                column: "Order_Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DriverPhones_Driver_Id",
                table: "DriverPhones",
                column: "Driver_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Drivers_License_Plate",
                table: "Drivers",
                column: "License_Plate",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Drivers_PrimaryPhoneNumber",
                table: "Drivers",
                column: "PrimaryPhoneNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Images_MenuItem_Id",
                table: "Images",
                column: "MenuItem_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Images_Promotion_Id",
                table: "Images",
                column: "Promotion_Id");

            migrationBuilder.CreateIndex(
                name: "IX_MenuCategoryItems_MenuCategory_Id",
                table: "MenuCategoryItems",
                column: "MenuCategory_Id");

            migrationBuilder.CreateIndex(
                name: "IX_MenuCategoryItems_MenuItem_Id",
                table: "MenuCategoryItems",
                column: "MenuItem_Id");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItemPromotions_MenuItem_Id",
                table: "MenuItemPromotions",
                column: "MenuItem_Id");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItemPromotions_Promotion_Id",
                table: "MenuItemPromotions",
                column: "Promotion_Id");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_Order_Id",
                table: "OrderItems",
                column: "Order_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Customer_Id",
                table: "Orders",
                column: "Customer_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PaymentMethod_Id",
                table: "Orders",
                column: "PaymentMethod_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_Customer_Id",
                table: "Reservations",
                column: "Customer_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_RestaurantTable_Id",
                table: "Reservations",
                column: "RestaurantTable_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_Customer_Id",
                table: "Reviews",
                column: "Customer_Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_MenuItem_Id",
                table: "Reviews",
                column: "MenuItem_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "CustomerPhones");

            migrationBuilder.DropTable(
                name: "Deliveries");

            migrationBuilder.DropTable(
                name: "DriverPhones");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "MenuCategoryItems");

            migrationBuilder.DropTable(
                name: "MenuItemPromotions");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "MenuCategories");

            migrationBuilder.DropTable(
                name: "Promotions");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "RestaurantTables");

            migrationBuilder.DropTable(
                name: "MenuItems");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "PaymentMethods");
        }
    }
}
