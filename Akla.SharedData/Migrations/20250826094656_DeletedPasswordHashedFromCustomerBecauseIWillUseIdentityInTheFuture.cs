using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Akla.SharedData.Migrations
{
    /// <inheritdoc />
    public partial class DeletedPasswordHashedFromCustomerBecauseIWillUseIdentityInTheFuture : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordHashed",
                table: "Customers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PasswordHashed",
                table: "Customers",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");
        }
    }
}
