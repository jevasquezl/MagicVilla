using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVillaAPI.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2023, 3, 8, 9, 18, 17, 619, DateTimeKind.Local).AddTicks(7092), new DateTime(2023, 3, 8, 9, 18, 17, 619, DateTimeKind.Local).AddTicks(7082) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2023, 3, 8, 9, 18, 17, 619, DateTimeKind.Local).AddTicks(7094), new DateTime(2023, 3, 8, 9, 18, 17, 619, DateTimeKind.Local).AddTicks(7094) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2023, 1, 14, 16, 14, 27, 223, DateTimeKind.Local).AddTicks(6466), new DateTime(2023, 1, 14, 16, 14, 27, 223, DateTimeKind.Local).AddTicks(6413) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2023, 1, 14, 16, 14, 27, 223, DateTimeKind.Local).AddTicks(6475), new DateTime(2023, 1, 14, 16, 14, 27, 223, DateTimeKind.Local).AddTicks(6472) });
        }
    }
}
