using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class RelacionesMedicos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_medico_consultorio",
                table: "medico",
                column: "consultorio");

            migrationBuilder.CreateIndex(
                name: "IX_medico_especialidad",
                table: "medico",
                column: "especialidad");

            migrationBuilder.AddForeignKey(
                name: "FK_medico_consultorio_consultorio",
                table: "medico",
                column: "consultorio",
                principalTable: "consultorio",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_medico_especialidad_especialidad",
                table: "medico",
                column: "especialidad",
                principalTable: "especialidad",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_medico_consultorio_consultorio",
                table: "medico");

            migrationBuilder.DropForeignKey(
                name: "FK_medico_especialidad_especialidad",
                table: "medico");

            migrationBuilder.DropIndex(
                name: "IX_medico_consultorio",
                table: "medico");

            migrationBuilder.DropIndex(
                name: "IX_medico_especialidad",
                table: "medico");
        }
    }
}
