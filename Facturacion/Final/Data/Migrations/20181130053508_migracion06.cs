using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Final.Data.Migrations
{
    public partial class migracion06 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "proveedorid",
                table: "productos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_productos_proveedorid",
                table: "productos",
                column: "proveedorid");

            migrationBuilder.AddForeignKey(
                name: "FK_productos_proveedores_proveedorid",
                table: "productos",
                column: "proveedorid",
                principalTable: "proveedores",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_productos_proveedores_proveedorid",
                table: "productos");

            migrationBuilder.DropIndex(
                name: "IX_productos_proveedorid",
                table: "productos");

            migrationBuilder.DropColumn(
                name: "proveedorid",
                table: "productos");
        }
    }
}
