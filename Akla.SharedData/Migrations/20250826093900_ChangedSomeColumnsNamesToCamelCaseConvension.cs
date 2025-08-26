using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Akla.SharedData.Migrations
{
    /// <inheritdoc />
    public partial class ChangedSomeColumnsNamesToCamelCaseConvension : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Customers_Customer_Id",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerPhones_Customers_Customer_Id",
                table: "CustomerPhones");

            migrationBuilder.DropForeignKey(
                name: "FK_Deliveries_Drivers_Driver_Id",
                table: "Deliveries");

            migrationBuilder.DropForeignKey(
                name: "FK_Deliveries_Orders_Order_Id",
                table: "Deliveries");

            migrationBuilder.DropForeignKey(
                name: "FK_DriverPhones_Drivers_Driver_Id",
                table: "DriverPhones");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_MenuItems_MenuItem_Id",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Promotions_Promotion_Id",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuCategoryItems_MenuCategories_MenuCategory_Id",
                table: "MenuCategoryItems");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuCategoryItems_MenuItems_MenuItem_Id",
                table: "MenuCategoryItems");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuItemPromotions_MenuItems_MenuItem_Id",
                table: "MenuItemPromotions");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuItemPromotions_Promotions_Promotion_Id",
                table: "MenuItemPromotions");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_MenuItems_Order_Id",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_Order_Id",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_Customer_Id",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_PaymentMethods_PaymentMethod_Id",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Customers_Customer_Id",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_RestaurantTables_RestaurantTable_Id",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Customers_Customer_Id",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_MenuItems_MenuItem_Id",
                table: "Reviews");

            migrationBuilder.RenameColumn(
                name: "Review_Date",
                table: "Reviews",
                newName: "ReviewDate");

            migrationBuilder.RenameColumn(
                name: "MenuItem_Id",
                table: "Reviews",
                newName: "MenuItemId");

            migrationBuilder.RenameColumn(
                name: "Customer_Id",
                table: "Reviews",
                newName: "CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_MenuItem_Id",
                table: "Reviews",
                newName: "IX_Reviews_MenuItemId");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_Customer_Id",
                table: "Reviews",
                newName: "IX_Reviews_CustomerId");

            migrationBuilder.RenameColumn(
                name: "Special_Requests",
                table: "Reservations",
                newName: "SpecialRequests");

            migrationBuilder.RenameColumn(
                name: "RestaurantTable_Id",
                table: "Reservations",
                newName: "RestaurantTableId");

            migrationBuilder.RenameColumn(
                name: "Reservatoin_Time",
                table: "Reservations",
                newName: "ReservatoinTime");

            migrationBuilder.RenameColumn(
                name: "Party_Size",
                table: "Reservations",
                newName: "PartySize");

            migrationBuilder.RenameColumn(
                name: "Customer_Id",
                table: "Reservations",
                newName: "CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_RestaurantTable_Id",
                table: "Reservations",
                newName: "IX_Reservations_RestaurantTableId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_Customer_Id",
                table: "Reservations",
                newName: "IX_Reservations_CustomerId");

            migrationBuilder.RenameColumn(
                name: "Start_Date",
                table: "Promotions",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "End_Date",
                table: "Promotions",
                newName: "EndDate");

            migrationBuilder.RenameColumn(
                name: "Discount_Value",
                table: "Promotions",
                newName: "DiscountValue");

            migrationBuilder.RenameColumn(
                name: "Discount_Type",
                table: "Promotions",
                newName: "DiscountType");

            migrationBuilder.RenameColumn(
                name: "Method_Name",
                table: "PaymentMethods",
                newName: "MethodName");

            migrationBuilder.RenameColumn(
                name: "Total_Amount",
                table: "Orders",
                newName: "TotalAmount");

            migrationBuilder.RenameColumn(
                name: "PaymentMethod_Id",
                table: "Orders",
                newName: "PaymentMethodId");

            migrationBuilder.RenameColumn(
                name: "Order_Time",
                table: "Orders",
                newName: "OrderTime");

            migrationBuilder.RenameColumn(
                name: "Delivery_Address",
                table: "Orders",
                newName: "DeliveryAddress");

            migrationBuilder.RenameColumn(
                name: "Customer_Id",
                table: "Orders",
                newName: "CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_PaymentMethod_Id",
                table: "Orders",
                newName: "IX_Orders_PaymentMethodId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_Customer_Id",
                table: "Orders",
                newName: "IX_Orders_CustomerId");

            migrationBuilder.RenameColumn(
                name: "Unit_Price",
                table: "OrderItems",
                newName: "UnitPrice");

            migrationBuilder.RenameColumn(
                name: "Special_Instructions",
                table: "OrderItems",
                newName: "SpecialInstructions");

            migrationBuilder.RenameColumn(
                name: "Order_Id",
                table: "OrderItems",
                newName: "OrderId");

            migrationBuilder.RenameColumn(
                name: "MenuItem_Id",
                table: "OrderItems",
                newName: "MenuItemId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItems_Order_Id",
                table: "OrderItems",
                newName: "IX_OrderItems_OrderId");

            migrationBuilder.RenameColumn(
                name: "Preparation_Time",
                table: "MenuItems",
                newName: "PreparationTime");

            migrationBuilder.RenameColumn(
                name: "Promotion_Id",
                table: "MenuItemPromotions",
                newName: "PromotionId");

            migrationBuilder.RenameColumn(
                name: "MenuItem_Id",
                table: "MenuItemPromotions",
                newName: "MenuItemId");

            migrationBuilder.RenameIndex(
                name: "IX_MenuItemPromotions_Promotion_Id",
                table: "MenuItemPromotions",
                newName: "IX_MenuItemPromotions_PromotionId");

            migrationBuilder.RenameIndex(
                name: "IX_MenuItemPromotions_MenuItem_Id",
                table: "MenuItemPromotions",
                newName: "IX_MenuItemPromotions_MenuItemId");

            migrationBuilder.RenameColumn(
                name: "MenuItem_Id",
                table: "MenuCategoryItems",
                newName: "MenuItemId");

            migrationBuilder.RenameColumn(
                name: "MenuCategory_Id",
                table: "MenuCategoryItems",
                newName: "MenuCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_MenuCategoryItems_MenuItem_Id",
                table: "MenuCategoryItems",
                newName: "IX_MenuCategoryItems_MenuItemId");

            migrationBuilder.RenameIndex(
                name: "IX_MenuCategoryItems_MenuCategory_Id",
                table: "MenuCategoryItems",
                newName: "IX_MenuCategoryItems_MenuCategoryId");

            migrationBuilder.RenameColumn(
                name: "Promotion_Id",
                table: "Images",
                newName: "PromotionId");

            migrationBuilder.RenameColumn(
                name: "MenuItem_Id",
                table: "Images",
                newName: "MenuItemId");

            migrationBuilder.RenameColumn(
                name: "Image_Url",
                table: "Images",
                newName: "ImageUrl");

            migrationBuilder.RenameIndex(
                name: "IX_Images_Promotion_Id",
                table: "Images",
                newName: "IX_Images_PromotionId");

            migrationBuilder.RenameIndex(
                name: "IX_Images_MenuItem_Id",
                table: "Images",
                newName: "IX_Images_MenuItemId");

            migrationBuilder.RenameColumn(
                name: "Vehicle_Type",
                table: "Drivers",
                newName: "VehicleType");

            migrationBuilder.RenameColumn(
                name: "License_Plate",
                table: "Drivers",
                newName: "LicensePlate");

            migrationBuilder.RenameIndex(
                name: "IX_Drivers_License_Plate",
                table: "Drivers",
                newName: "IX_Drivers_LicensePlate");

            migrationBuilder.RenameColumn(
                name: "Phone_Number",
                table: "DriverPhones",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "Driver_Id",
                table: "DriverPhones",
                newName: "DriverId");

            migrationBuilder.RenameIndex(
                name: "IX_DriverPhones_Driver_Id",
                table: "DriverPhones",
                newName: "IX_DriverPhones_DriverId");

            migrationBuilder.RenameColumn(
                name: "Order_Id",
                table: "Deliveries",
                newName: "OrderId");

            migrationBuilder.RenameColumn(
                name: "Driver_Id",
                table: "Deliveries",
                newName: "DriverId");

            migrationBuilder.RenameColumn(
                name: "Dispath_Time",
                table: "Deliveries",
                newName: "DispathTime");

            migrationBuilder.RenameColumn(
                name: "Delivery_Time",
                table: "Deliveries",
                newName: "DeliveryTime");

            migrationBuilder.RenameIndex(
                name: "IX_Deliveries_Order_Id",
                table: "Deliveries",
                newName: "IX_Deliveries_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_Deliveries_Driver_Id",
                table: "Deliveries",
                newName: "IX_Deliveries_DriverId");

            migrationBuilder.RenameColumn(
                name: "Join_Date",
                table: "Customers",
                newName: "JoinDate");

            migrationBuilder.RenameColumn(
                name: "Phone_Number",
                table: "CustomerPhones",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "Customer_Id",
                table: "CustomerPhones",
                newName: "CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerPhones_Customer_Id",
                table: "CustomerPhones",
                newName: "IX_CustomerPhones_CustomerId");

            migrationBuilder.RenameColumn(
                name: "Customer_Id",
                table: "Addresses",
                newName: "CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Addresses_Customer_Id",
                table: "Addresses",
                newName: "IX_Addresses_CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Customers_CustomerId",
                table: "Addresses",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerPhones_Customers_CustomerId",
                table: "CustomerPhones",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Deliveries_Drivers_DriverId",
                table: "Deliveries",
                column: "DriverId",
                principalTable: "Drivers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Deliveries_Orders_OrderId",
                table: "Deliveries",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DriverPhones_Drivers_DriverId",
                table: "DriverPhones",
                column: "DriverId",
                principalTable: "Drivers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_MenuItems_MenuItemId",
                table: "Images",
                column: "MenuItemId",
                principalTable: "MenuItems",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Promotions_PromotionId",
                table: "Images",
                column: "PromotionId",
                principalTable: "Promotions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MenuCategoryItems_MenuCategories_MenuCategoryId",
                table: "MenuCategoryItems",
                column: "MenuCategoryId",
                principalTable: "MenuCategories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MenuCategoryItems_MenuItems_MenuItemId",
                table: "MenuCategoryItems",
                column: "MenuItemId",
                principalTable: "MenuItems",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MenuItemPromotions_MenuItems_MenuItemId",
                table: "MenuItemPromotions",
                column: "MenuItemId",
                principalTable: "MenuItems",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MenuItemPromotions_Promotions_PromotionId",
                table: "MenuItemPromotions",
                column: "PromotionId",
                principalTable: "Promotions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_MenuItems_OrderId",
                table: "OrderItems",
                column: "OrderId",
                principalTable: "MenuItems",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_PaymentMethods_PaymentMethodId",
                table: "Orders",
                column: "PaymentMethodId",
                principalTable: "PaymentMethods",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Customers_CustomerId",
                table: "Reservations",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_RestaurantTables_RestaurantTableId",
                table: "Reservations",
                column: "RestaurantTableId",
                principalTable: "RestaurantTables",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Customers_CustomerId",
                table: "Reviews",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_MenuItems_MenuItemId",
                table: "Reviews",
                column: "MenuItemId",
                principalTable: "MenuItems",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Customers_CustomerId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerPhones_Customers_CustomerId",
                table: "CustomerPhones");

            migrationBuilder.DropForeignKey(
                name: "FK_Deliveries_Drivers_DriverId",
                table: "Deliveries");

            migrationBuilder.DropForeignKey(
                name: "FK_Deliveries_Orders_OrderId",
                table: "Deliveries");

            migrationBuilder.DropForeignKey(
                name: "FK_DriverPhones_Drivers_DriverId",
                table: "DriverPhones");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_MenuItems_MenuItemId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Promotions_PromotionId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuCategoryItems_MenuCategories_MenuCategoryId",
                table: "MenuCategoryItems");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuCategoryItems_MenuItems_MenuItemId",
                table: "MenuCategoryItems");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuItemPromotions_MenuItems_MenuItemId",
                table: "MenuItemPromotions");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuItemPromotions_Promotions_PromotionId",
                table: "MenuItemPromotions");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_MenuItems_OrderId",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_PaymentMethods_PaymentMethodId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Customers_CustomerId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_RestaurantTables_RestaurantTableId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Customers_CustomerId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_MenuItems_MenuItemId",
                table: "Reviews");

            migrationBuilder.RenameColumn(
                name: "ReviewDate",
                table: "Reviews",
                newName: "Review_Date");

            migrationBuilder.RenameColumn(
                name: "MenuItemId",
                table: "Reviews",
                newName: "MenuItem_Id");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Reviews",
                newName: "Customer_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_MenuItemId",
                table: "Reviews",
                newName: "IX_Reviews_MenuItem_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_CustomerId",
                table: "Reviews",
                newName: "IX_Reviews_Customer_Id");

            migrationBuilder.RenameColumn(
                name: "SpecialRequests",
                table: "Reservations",
                newName: "Special_Requests");

            migrationBuilder.RenameColumn(
                name: "RestaurantTableId",
                table: "Reservations",
                newName: "RestaurantTable_Id");

            migrationBuilder.RenameColumn(
                name: "ReservatoinTime",
                table: "Reservations",
                newName: "Reservatoin_Time");

            migrationBuilder.RenameColumn(
                name: "PartySize",
                table: "Reservations",
                newName: "Party_Size");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Reservations",
                newName: "Customer_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_RestaurantTableId",
                table: "Reservations",
                newName: "IX_Reservations_RestaurantTable_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_CustomerId",
                table: "Reservations",
                newName: "IX_Reservations_Customer_Id");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "Promotions",
                newName: "Start_Date");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "Promotions",
                newName: "End_Date");

            migrationBuilder.RenameColumn(
                name: "DiscountValue",
                table: "Promotions",
                newName: "Discount_Value");

            migrationBuilder.RenameColumn(
                name: "DiscountType",
                table: "Promotions",
                newName: "Discount_Type");

            migrationBuilder.RenameColumn(
                name: "MethodName",
                table: "PaymentMethods",
                newName: "Method_Name");

            migrationBuilder.RenameColumn(
                name: "TotalAmount",
                table: "Orders",
                newName: "Total_Amount");

            migrationBuilder.RenameColumn(
                name: "PaymentMethodId",
                table: "Orders",
                newName: "PaymentMethod_Id");

            migrationBuilder.RenameColumn(
                name: "OrderTime",
                table: "Orders",
                newName: "Order_Time");

            migrationBuilder.RenameColumn(
                name: "DeliveryAddress",
                table: "Orders",
                newName: "Delivery_Address");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Orders",
                newName: "Customer_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_PaymentMethodId",
                table: "Orders",
                newName: "IX_Orders_PaymentMethod_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                newName: "IX_Orders_Customer_Id");

            migrationBuilder.RenameColumn(
                name: "UnitPrice",
                table: "OrderItems",
                newName: "Unit_Price");

            migrationBuilder.RenameColumn(
                name: "SpecialInstructions",
                table: "OrderItems",
                newName: "Special_Instructions");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "OrderItems",
                newName: "Order_Id");

            migrationBuilder.RenameColumn(
                name: "MenuItemId",
                table: "OrderItems",
                newName: "MenuItem_Id");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                newName: "IX_OrderItems_Order_Id");

            migrationBuilder.RenameColumn(
                name: "PreparationTime",
                table: "MenuItems",
                newName: "Preparation_Time");

            migrationBuilder.RenameColumn(
                name: "PromotionId",
                table: "MenuItemPromotions",
                newName: "Promotion_Id");

            migrationBuilder.RenameColumn(
                name: "MenuItemId",
                table: "MenuItemPromotions",
                newName: "MenuItem_Id");

            migrationBuilder.RenameIndex(
                name: "IX_MenuItemPromotions_PromotionId",
                table: "MenuItemPromotions",
                newName: "IX_MenuItemPromotions_Promotion_Id");

            migrationBuilder.RenameIndex(
                name: "IX_MenuItemPromotions_MenuItemId",
                table: "MenuItemPromotions",
                newName: "IX_MenuItemPromotions_MenuItem_Id");

            migrationBuilder.RenameColumn(
                name: "MenuItemId",
                table: "MenuCategoryItems",
                newName: "MenuItem_Id");

            migrationBuilder.RenameColumn(
                name: "MenuCategoryId",
                table: "MenuCategoryItems",
                newName: "MenuCategory_Id");

            migrationBuilder.RenameIndex(
                name: "IX_MenuCategoryItems_MenuItemId",
                table: "MenuCategoryItems",
                newName: "IX_MenuCategoryItems_MenuItem_Id");

            migrationBuilder.RenameIndex(
                name: "IX_MenuCategoryItems_MenuCategoryId",
                table: "MenuCategoryItems",
                newName: "IX_MenuCategoryItems_MenuCategory_Id");

            migrationBuilder.RenameColumn(
                name: "PromotionId",
                table: "Images",
                newName: "Promotion_Id");

            migrationBuilder.RenameColumn(
                name: "MenuItemId",
                table: "Images",
                newName: "MenuItem_Id");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Images",
                newName: "Image_Url");

            migrationBuilder.RenameIndex(
                name: "IX_Images_PromotionId",
                table: "Images",
                newName: "IX_Images_Promotion_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Images_MenuItemId",
                table: "Images",
                newName: "IX_Images_MenuItem_Id");

            migrationBuilder.RenameColumn(
                name: "VehicleType",
                table: "Drivers",
                newName: "Vehicle_Type");

            migrationBuilder.RenameColumn(
                name: "LicensePlate",
                table: "Drivers",
                newName: "License_Plate");

            migrationBuilder.RenameIndex(
                name: "IX_Drivers_LicensePlate",
                table: "Drivers",
                newName: "IX_Drivers_License_Plate");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "DriverPhones",
                newName: "Phone_Number");

            migrationBuilder.RenameColumn(
                name: "DriverId",
                table: "DriverPhones",
                newName: "Driver_Id");

            migrationBuilder.RenameIndex(
                name: "IX_DriverPhones_DriverId",
                table: "DriverPhones",
                newName: "IX_DriverPhones_Driver_Id");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "Deliveries",
                newName: "Order_Id");

            migrationBuilder.RenameColumn(
                name: "DriverId",
                table: "Deliveries",
                newName: "Driver_Id");

            migrationBuilder.RenameColumn(
                name: "DispathTime",
                table: "Deliveries",
                newName: "Dispath_Time");

            migrationBuilder.RenameColumn(
                name: "DeliveryTime",
                table: "Deliveries",
                newName: "Delivery_Time");

            migrationBuilder.RenameIndex(
                name: "IX_Deliveries_OrderId",
                table: "Deliveries",
                newName: "IX_Deliveries_Order_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Deliveries_DriverId",
                table: "Deliveries",
                newName: "IX_Deliveries_Driver_Id");

            migrationBuilder.RenameColumn(
                name: "JoinDate",
                table: "Customers",
                newName: "Join_Date");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "CustomerPhones",
                newName: "Phone_Number");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "CustomerPhones",
                newName: "Customer_Id");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerPhones_CustomerId",
                table: "CustomerPhones",
                newName: "IX_CustomerPhones_Customer_Id");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Addresses",
                newName: "Customer_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Addresses_CustomerId",
                table: "Addresses",
                newName: "IX_Addresses_Customer_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Customers_Customer_Id",
                table: "Addresses",
                column: "Customer_Id",
                principalTable: "Customers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerPhones_Customers_Customer_Id",
                table: "CustomerPhones",
                column: "Customer_Id",
                principalTable: "Customers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Deliveries_Drivers_Driver_Id",
                table: "Deliveries",
                column: "Driver_Id",
                principalTable: "Drivers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Deliveries_Orders_Order_Id",
                table: "Deliveries",
                column: "Order_Id",
                principalTable: "Orders",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DriverPhones_Drivers_Driver_Id",
                table: "DriverPhones",
                column: "Driver_Id",
                principalTable: "Drivers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_MenuItems_MenuItem_Id",
                table: "Images",
                column: "MenuItem_Id",
                principalTable: "MenuItems",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Promotions_Promotion_Id",
                table: "Images",
                column: "Promotion_Id",
                principalTable: "Promotions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MenuCategoryItems_MenuCategories_MenuCategory_Id",
                table: "MenuCategoryItems",
                column: "MenuCategory_Id",
                principalTable: "MenuCategories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MenuCategoryItems_MenuItems_MenuItem_Id",
                table: "MenuCategoryItems",
                column: "MenuItem_Id",
                principalTable: "MenuItems",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MenuItemPromotions_MenuItems_MenuItem_Id",
                table: "MenuItemPromotions",
                column: "MenuItem_Id",
                principalTable: "MenuItems",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MenuItemPromotions_Promotions_Promotion_Id",
                table: "MenuItemPromotions",
                column: "Promotion_Id",
                principalTable: "Promotions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_MenuItems_Order_Id",
                table: "OrderItems",
                column: "Order_Id",
                principalTable: "MenuItems",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_Order_Id",
                table: "OrderItems",
                column: "Order_Id",
                principalTable: "Orders",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_Customer_Id",
                table: "Orders",
                column: "Customer_Id",
                principalTable: "Customers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_PaymentMethods_PaymentMethod_Id",
                table: "Orders",
                column: "PaymentMethod_Id",
                principalTable: "PaymentMethods",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Customers_Customer_Id",
                table: "Reservations",
                column: "Customer_Id",
                principalTable: "Customers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_RestaurantTables_RestaurantTable_Id",
                table: "Reservations",
                column: "RestaurantTable_Id",
                principalTable: "RestaurantTables",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Customers_Customer_Id",
                table: "Reviews",
                column: "Customer_Id",
                principalTable: "Customers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_MenuItems_MenuItem_Id",
                table: "Reviews",
                column: "MenuItem_Id",
                principalTable: "MenuItems",
                principalColumn: "Id");
        }
    }
}
