using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class RelacionesRequired : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_usuario_acudiente_acudiente",
                table: "usuario");

            migrationBuilder.DropForeignKey(
                name: "FK_usuario_genero_genero",
                table: "usuario");

            migrationBuilder.DropForeignKey(
                name: "FK_usuario_tipo_documento_tipodoc",
                table: "usuario");

            migrationBuilder.AlterColumn<int>(
                name: "tipodoc",
                table: "usuario",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "genero",
                table: "usuario",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "acudiente",
                table: "usuario",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_usuario_acudiente_acudiente",
                table: "usuario",
                column: "acudiente",
                principalTable: "acudiente",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_usuario_genero_genero",
                table: "usuario",
                column: "genero",
                principalTable: "genero",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_usuario_tipo_documento_tipodoc",
                table: "usuario",
                column: "tipodoc",
                principalTable: "tipo_documento",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_usuario_acudiente_acudiente",
                table: "usuario");

            migrationBuilder.DropForeignKey(
                name: "FK_usuario_genero_genero",
                table: "usuario");

            migrationBuilder.DropForeignKey(
                name: "FK_usuario_tipo_documento_tipodoc",
                table: "usuario");

            migrationBuilder.AlterColumn<int>(
                name: "tipodoc",
                table: "usuario",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "genero",
                table: "usuario",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "acudiente",
                table: "usuario",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_usuario_acudiente_acudiente",
                table: "usuario",
                column: "acudiente",
                principalTable: "acudiente",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_usuario_genero_genero",
                table: "usuario",
                column: "genero",
                principalTable: "genero",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_usuario_tipo_documento_tipodoc",
                table: "usuario",
                column: "tipodoc",
                principalTable: "tipo_documento",
                principalColumn: "id");
        }
    }
}
