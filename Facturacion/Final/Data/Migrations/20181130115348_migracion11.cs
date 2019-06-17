using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Final.Data.Migrations
{
    public partial class migracion11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_productos_proveedores_proveedorid",
                table: "productos");

            migrationBuilder.DropTable(
                name: "proveedores");

            migrationBuilder.DropIndex(
                name: "IX_productos_proveedorid",
                table: "productos");

            migrationBuilder.DropColumn(
                name: "proveedorid",
                table: "productos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "proveedorid",
                table: "productos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "proveedores",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Detalle = table.Column<string>(nullable: false),
                    nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_proveedores", x => x.id);
                });

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
    }
}
