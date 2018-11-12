using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Simulador2.Migrations
{
    public partial class Simulador2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alumnos",
                columns: table => new
                {
                    Idperfil = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ApellidosM = table.Column<string>(maxLength: 85, nullable: false),
                    ApellidosP = table.Column<string>(maxLength: 85, nullable: false),
                    Ciudad = table.Column<string>(maxLength: 90, nullable: false),
                    CodigoPostal = table.Column<string>(maxLength: 6, nullable: false),
                    Colonia = table.Column<string>(maxLength: 85, nullable: false),
                    Domicilio = table.Column<string>(maxLength: 110, nullable: false),
                    Email = table.Column<string>(maxLength: 85, nullable: false),
                    Estado = table.Column<string>(maxLength: 85, nullable: false),
                    Nombres = table.Column<string>(maxLength: 85, nullable: false),
                    NumTelefono = table.Column<string>(maxLength: 15, nullable: false),
                    Rfc = table.Column<string>(maxLength: 12, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alumnos", x => x.Idperfil);
                });

            migrationBuilder.CreateTable(
                name: "EstimacionServicios",
                columns: table => new
                {
                    Idsuscripcion = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TotalMensual = table.Column<string>(maxLength: 85, nullable: false),
                    TotalSuscripciones = table.Column<int>(maxLength: 85, nullable: false),
                    unidad_produccion = table.Column<string>(maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstimacionServicios", x => x.Idsuscripcion);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alumnos");

            migrationBuilder.DropTable(
                name: "EstimacionServicios");
        }
    }
}
