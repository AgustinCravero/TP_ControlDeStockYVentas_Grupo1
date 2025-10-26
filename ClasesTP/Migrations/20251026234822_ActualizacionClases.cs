using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClasesTP.Migrations
{
    /// <inheritdoc />
    public partial class ActualizacionClases : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetallesEntrega");

            migrationBuilder.DropTable(
                name: "EntregasProveedor");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EntregasProveedor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProveedorId = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntregasProveedor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EntregasProveedor_Proveedores_ProveedorId",
                        column: x => x.ProveedorId,
                        principalTable: "Proveedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetallesEntrega",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntregaProveedorId = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    ProductoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallesEntrega", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DetallesEntrega_EntregasProveedor_EntregaProveedorId",
                        column: x => x.EntregaProveedorId,
                        principalTable: "EntregasProveedor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetallesEntrega_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetallesEntrega_EntregaProveedorId",
                table: "DetallesEntrega",
                column: "EntregaProveedorId");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesEntrega_ProductoId",
                table: "DetallesEntrega",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_EntregasProveedor_ProveedorId",
                table: "EntregasProveedor",
                column: "ProveedorId");
        }
    }
}
