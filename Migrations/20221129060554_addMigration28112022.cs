using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PrestaFacil.Migrations
{
    public partial class addMigration28112022 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Compania",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: false),
                    Direccion = table.Column<string>(nullable: false),
                    Rnc = table.Column<string>(nullable: false),
                    Telefono1 = table.Column<string>(nullable: true),
                    Telefono2 = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Contacto = table.Column<string>(nullable: true),
                    Telefono_Contacto = table.Column<string>(nullable: true),
                    usrcre = table.Column<string>(nullable: true),
                    feccre = table.Column<DateTime>(nullable: false),
                    usrmod = table.Column<string>(nullable: true),
                    fecmod = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compania", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tipo_Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipo_Cliente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: false),
                    Tipo_clienteId = table.Column<int>(nullable: false),
                    Rnc_cedula = table.Column<string>(nullable: false),
                    Direccion = table.Column<string>(nullable: false),
                    Telefono1 = table.Column<string>(nullable: true),
                    Telefono2 = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Contacto = table.Column<string>(nullable: true),
                    Telefono_contacto = table.Column<string>(nullable: true),
                    Usrcre = table.Column<string>(nullable: true),
                    Feccre = table.Column<DateTime>(nullable: false),
                    Usrmod = table.Column<string>(nullable: true),
                    Fecmod = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cliente_Tipo_Cliente_Tipo_clienteId",
                        column: x => x.Tipo_clienteId,
                        principalTable: "Tipo_Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_Tipo_clienteId",
                table: "Cliente",
                column: "Tipo_clienteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Compania");

            migrationBuilder.DropTable(
                name: "Tipo_Cliente");
        }
    }
}
