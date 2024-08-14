using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kfc.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class DropColumnId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MenuTypeId",
                table: "MenuTypes");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ComboId",
                table: "Combos");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MenuTypeId",
                table: "MenuTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ComboId",
                table: "Combos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
