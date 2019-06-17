using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Final.Data.Migrations
{
    public partial class migracion08 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_factura_productos_productosId",
                table: "factura");

            migrationBuilder.DropIndex(
                name: "IX_factura_productosId",
                table: "factura");

            migrationBuilder.DropColumn(
                name: "productosId",
                table: "factura");

            migrationBuilder.AddColumn<int>(
                name: "facturaid",
                table: "productos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_productos_facturaid",
                table: "productos",
                column: "facturaid");

            migrationBuilder.AddForeignKey(
                name: "FK_productos_factura_facturaid",
                table: "productos",
                column: "facturaid",
                principalTable: "factura",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_productos_factura_facturaid",
                table: "productos");

            migrationBuilder.DropIndex(
                name: "IX_productos_facturaid",
                table: "productos");

            migrationBuilder.DropColumn(
                name: "facturaid",
                table: "productos");

            migrationBuilder.AddColumn<int>(
                name: "productosId",
                table: "factura",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_factura_productosId",
                table: "factura",
                column: "productosId");

            migrationBuilder.AddForeignKey(
                name: "FK_factura_productos_productosId",
                table: "factura",
                column: "productosId",
                principalTable: "productos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
