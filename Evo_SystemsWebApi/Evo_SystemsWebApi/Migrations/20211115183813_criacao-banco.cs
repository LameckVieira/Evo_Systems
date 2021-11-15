using Microsoft.EntityFrameworkCore.Migrations;

namespace Evo_SystemsWebApi.Migrations
{
    public partial class criacaobanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departamento",
                columns: table => new
                {
                    idDepartamento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(150)", nullable: false),
                    Sigla = table.Column<string>(type: "varchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamento", x => x.idDepartamento);
                });

            migrationBuilder.CreateTable(
                name: "Funcionario",
                columns: table => new
                {
                    idFuncionario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(150)", nullable: false),
                    Foto = table.Column<string>(type: "varchar(150)", nullable: false),
                    RG = table.Column<string>(type: "varchar(20)", nullable: false),
                    idDepartamento = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionario", x => x.idFuncionario);
                    table.ForeignKey(
                        name: "FK_Funcionario_Departamento_idDepartamento",
                        column: x => x.idDepartamento,
                        principalTable: "Departamento",
                        principalColumn: "idDepartamento",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departamento",
                columns: new[] { "idDepartamento", "Nome", "Sigla" },
                values: new object[] { 1, "Recursos Humanos", "RH" });

            migrationBuilder.InsertData(
                table: "Funcionario",
                columns: new[] { "idFuncionario", "Foto", "Nome", "RG", "idDepartamento" },
                values: new object[] { 1, "Foto.png", "Lameck", "586985896", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_idDepartamento",
                table: "Funcionario",
                column: "idDepartamento");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Funcionario");

            migrationBuilder.DropTable(
                name: "Departamento");
        }
    }
}
