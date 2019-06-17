using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Final.Data.Migrations
{
    public partial class migracion07 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_factura_productos_productosid",
                table: "factura");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "productos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "productosid",
                table: "factura",
                newName: "productosId");

            migrationBuilder.RenameIndex(
                name: "IX_factura_productosid",
                table: "factura",
                newName: "IX_factura_productosId");

            migrationBuilder.AddForeignKey(
                name: "FK_factura_productos_productosId",
                table: "factura",
                column: "productosId",
                principalTable: "productos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_factura_productos_productosId",
                table: "factura");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "productos",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "productosId",
                table: "factura",
                newName: "productosid");

            migrationBuilder.RenameIndex(
                name: "IX_factura_productosId",
                table: "factura",
                newName: "IX_factura_productosid");

            migrationBuilder.AddForeignKey(
                name: "FK_factura_productos_productosid",
                table: "factura",
                column: "productosid",
                principalTable: "productos",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
