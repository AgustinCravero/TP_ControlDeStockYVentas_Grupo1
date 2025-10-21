using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClasesTP.Migrations
{
    /// <inheritdoc />
    public partial class NuevosDbSets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetalleEntrega_EntregaProveedor_EntregaProveedorId",
                table: "DetalleEntrega");

            migrationBuilder.DropForeignKey(
                name: "FK_DetalleEntrega_Productos_ProductoId",
                table: "DetalleEntrega");

            migrationBuilder.DropForeignKey(
                name: "FK_DetalleVenta_Productos_ProductoId",
                table: "DetalleVenta");

            migrationBuilder.DropForeignKey(
                name: "FK_DetalleVenta_Ventas_VentaId",
                table: "DetalleVenta");

            migrationBuilder.DropForeignKey(
                name: "FK_EntregaProveedor_Proveedores_ProveedorId",
                table: "EntregaProveedor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EntregaProveedor",
                table: "EntregaProveedor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DetalleVenta",
                table: "DetalleVenta");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DetalleEntrega",
                table: "DetalleEntrega");

            migrationBuilder.RenameTable(
                name: "EntregaProveedor",
                newName: "EntregasProveedor");

            migrationBuilder.RenameTable(
                name: "DetalleVenta",
                newName: "DetallesVenta");

            migrationBuilder.RenameTable(
                name: "DetalleEntrega",
                newName: "DetallesEntrega");

            migrationBuilder.RenameIndex(
                name: "IX_EntregaProveedor_ProveedorId",
                table: "EntregasProveedor",
                newName: "IX_EntregasProveedor_ProveedorId");

            migrationBuilder.RenameIndex(
                name: "IX_DetalleVenta_VentaId",
                table: "DetallesVenta",
                newName: "IX_DetallesVenta_VentaId");

            migrationBuilder.RenameIndex(
                name: "IX_DetalleVenta_ProductoId",
                table: "DetallesVenta",
                newName: "IX_DetallesVenta_ProductoId");

            migrationBuilder.RenameIndex(
                name: "IX_DetalleEntrega_ProductoId",
                table: "DetallesEntrega",
                newName: "IX_DetallesEntrega_ProductoId");

            migrationBuilder.RenameIndex(
                name: "IX_DetalleEntrega_EntregaProveedorId",
                table: "DetallesEntrega",
                newName: "IX_DetallesEntrega_EntregaProveedorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EntregasProveedor",
                table: "EntregasProveedor",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DetallesVenta",
                table: "DetallesVenta",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DetallesEntrega",
                table: "DetallesEntrega",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_DetallesEntrega_EntregasProveedor_EntregaProveedorId",
                table: "DetallesEntrega",
                column: "EntregaProveedorId",
                principalTable: "EntregasProveedor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetallesEntrega_Productos_ProductoId",
                table: "DetallesEntrega",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetallesVenta_Productos_ProductoId",
                table: "DetallesVenta",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetallesVenta_Ventas_VentaId",
                table: "DetallesVenta",
                column: "VentaId",
                principalTable: "Ventas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EntregasProveedor_Proveedores_ProveedorId",
                table: "EntregasProveedor",
                column: "ProveedorId",
                principalTable: "Proveedores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetallesEntrega_EntregasProveedor_EntregaProveedorId",
                table: "DetallesEntrega");

            migrationBuilder.DropForeignKey(
                name: "FK_DetallesEntrega_Productos_ProductoId",
                table: "DetallesEntrega");

            migrationBuilder.DropForeignKey(
                name: "FK_DetallesVenta_Productos_ProductoId",
                table: "DetallesVenta");

            migrationBuilder.DropForeignKey(
                name: "FK_DetallesVenta_Ventas_VentaId",
                table: "DetallesVenta");

            migrationBuilder.DropForeignKey(
                name: "FK_EntregasProveedor_Proveedores_ProveedorId",
                table: "EntregasProveedor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EntregasProveedor",
                table: "EntregasProveedor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DetallesVenta",
                table: "DetallesVenta");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DetallesEntrega",
                table: "DetallesEntrega");

            migrationBuilder.RenameTable(
                name: "EntregasProveedor",
                newName: "EntregaProveedor");

            migrationBuilder.RenameTable(
                name: "DetallesVenta",
                newName: "DetalleVenta");

            migrationBuilder.RenameTable(
                name: "DetallesEntrega",
                newName: "DetalleEntrega");

            migrationBuilder.RenameIndex(
                name: "IX_EntregasProveedor_ProveedorId",
                table: "EntregaProveedor",
                newName: "IX_EntregaProveedor_ProveedorId");

            migrationBuilder.RenameIndex(
                name: "IX_DetallesVenta_VentaId",
                table: "DetalleVenta",
                newName: "IX_DetalleVenta_VentaId");

            migrationBuilder.RenameIndex(
                name: "IX_DetallesVenta_ProductoId",
                table: "DetalleVenta",
                newName: "IX_DetalleVenta_ProductoId");

            migrationBuilder.RenameIndex(
                name: "IX_DetallesEntrega_ProductoId",
                table: "DetalleEntrega",
                newName: "IX_DetalleEntrega_ProductoId");

            migrationBuilder.RenameIndex(
                name: "IX_DetallesEntrega_EntregaProveedorId",
                table: "DetalleEntrega",
                newName: "IX_DetalleEntrega_EntregaProveedorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EntregaProveedor",
                table: "EntregaProveedor",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DetalleVenta",
                table: "DetalleVenta",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DetalleEntrega",
                table: "DetalleEntrega",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleEntrega_EntregaProveedor_EntregaProveedorId",
                table: "DetalleEntrega",
                column: "EntregaProveedorId",
                principalTable: "EntregaProveedor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleEntrega_Productos_ProductoId",
                table: "DetalleEntrega",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleVenta_Productos_ProductoId",
                table: "DetalleVenta",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleVenta_Ventas_VentaId",
                table: "DetalleVenta",
                column: "VentaId",
                principalTable: "Ventas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EntregaProveedor_Proveedores_ProveedorId",
                table: "EntregaProveedor",
                column: "ProveedorId",
                principalTable: "Proveedores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
