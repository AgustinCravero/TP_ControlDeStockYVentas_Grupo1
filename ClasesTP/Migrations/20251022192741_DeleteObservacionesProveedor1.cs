using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClasesTP.Migrations
{
    /// <inheritdoc />
    public partial class DeleteObservacionesProveedor1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Observaciones",
                table: "Proveedores");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Observaciones",
                table: "Proveedores",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
