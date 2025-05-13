using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestionDeStock.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddNotesColumnToStockIn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "StockIns",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Notes",
                table: "StockIns");
        }
    }
}
