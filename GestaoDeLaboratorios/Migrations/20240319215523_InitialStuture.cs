using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoDeLaboratorios.Migrations
{
    /// <inheritdoc />
    public partial class InitialStuture : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Computador",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Processador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlacaMae = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Memoria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroPatrimonio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataCompra = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Computador", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Computador");
        }
    }
}
