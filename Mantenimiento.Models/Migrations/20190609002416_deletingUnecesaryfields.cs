using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mantenimiento.Models.Migrations
{
    public partial class deletingUnecesaryfields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActualizadoPor",
                table: "Residents");

            migrationBuilder.DropColumn(
                name: "CreadoPor",
                table: "Residents");

            migrationBuilder.DropColumn(
                name: "FechaActualizacion",
                table: "Residents");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "Residents");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ActualizadoPor",
                table: "Residents",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreadoPor",
                table: "Residents",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaActualizacion",
                table: "Residents",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreacion",
                table: "Residents",
                nullable: true);
        }
    }
}
