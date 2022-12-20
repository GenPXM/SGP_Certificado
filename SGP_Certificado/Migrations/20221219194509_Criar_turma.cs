using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SGPCertificado.Migrations
{
    /// <inheritdoc />
    public partial class Criarturma : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cadastro_Turmas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCurso = table.Column<string>(name: "Nome_Curso", type: "nvarchar(max)", nullable: false),
                    NomeProfessor = table.Column<string>(name: "Nome_Professor", type: "nvarchar(max)", nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HorarioInicio = table.Column<DateTime>(name: "Horario_Inicio", type: "datetime2", nullable: false),
                    HorarioFim = table.Column<DateTime>(name: "Horario_Fim", type: "datetime2", nullable: false),
                    Empresa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cadastro_Turmas", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cadastro_Turmas");
        }
    }
}
