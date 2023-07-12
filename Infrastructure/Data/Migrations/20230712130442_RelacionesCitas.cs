using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class RelacionesCitas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_cita_datosUsuario",
                table: "cita",
                column: "datosUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_cita_estadoCita",
                table: "cita",
                column: "estadoCita");

            migrationBuilder.CreateIndex(
                name: "IX_cita_medico",
                table: "cita",
                column: "medico");

            migrationBuilder.AddForeignKey(
                name: "FK_cita_estado_cita_estadoCita",
                table: "cita",
                column: "estadoCita",
                principalTable: "estado_cita",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_cita_medico_medico",
                table: "cita",
                column: "medico",
                principalTable: "medico",
                principalColumn: "nroMatriculaProfesional",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_cita_usuario_datosUsuario",
                table: "cita",
                column: "datosUsuario",
                principalTable: "usuario",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cita_estado_cita_estadoCita",
                table: "cita");

            migrationBuilder.DropForeignKey(
                name: "FK_cita_medico_medico",
                table: "cita");

            migrationBuilder.DropForeignKey(
                name: "FK_cita_usuario_datosUsuario",
                table: "cita");

            migrationBuilder.DropIndex(
                name: "IX_cita_datosUsuario",
                table: "cita");

            migrationBuilder.DropIndex(
                name: "IX_cita_estadoCita",
                table: "cita");

            migrationBuilder.DropIndex(
                name: "IX_cita_medico",
                table: "cita");
        }
    }
}
