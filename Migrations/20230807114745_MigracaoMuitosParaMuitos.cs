using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoMuitosParaMuitos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Derrotas",
                table: "Personagens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Disputas",
                table: "Personagens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vitorias",
                table: "Personagens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Habilidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dano = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habilidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonagemHabilidades",
                columns: table => new
                {
                    PersonagemId = table.Column<int>(type: "int", nullable: false),
                    HabilidadeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonagemHabilidades", x => new { x.PersonagemId, x.HabilidadeId });
                    table.ForeignKey(
                        name: "FK_PersonagemHabilidades_Habilidades_HabilidadeId",
                        column: x => x.HabilidadeId,
                        principalTable: "Habilidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonagemHabilidades_Personagens_PersonagemId",
                        column: x => x.PersonagemId,
                        principalTable: "Personagens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Habilidades",
                columns: new[] { "Id", "Dano", "Nome" },
                values: new object[,]
                {
                    { 1, 39, "Adormecer" },
                    { 2, 41, "Congelar" },
                    { 3, 37, "Hipnotizar" }
                });

            migrationBuilder.UpdateData(
                table: "Personagens",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Personagens",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Personagens",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Personagens",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Personagens",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Personagens",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Personagens",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 203, 22, 208, 12, 168, 19, 61, 232, 15, 195, 235, 189, 216, 73, 240, 137, 90, 67, 33, 63, 175, 233, 218, 82, 225, 93, 238, 54, 7, 94, 224, 105, 211, 130, 172, 237, 192, 27, 200, 107, 99, 102, 1, 188, 126, 155, 164, 18, 71, 4, 196, 41, 180, 204, 223, 217, 122, 212, 140, 220, 247, 91, 105, 243 }, new byte[] { 156, 182, 113, 190, 168, 236, 51, 140, 217, 222, 185, 101, 68, 237, 16, 152, 11, 27, 43, 147, 142, 154, 233, 139, 47, 224, 51, 105, 153, 52, 91, 221, 100, 68, 63, 246, 149, 11, 57, 173, 198, 235, 21, 21, 130, 162, 48, 167, 68, 231, 86, 232, 28, 153, 183, 151, 240, 236, 186, 251, 255, 3, 75, 41, 221, 165, 1, 59, 199, 233, 54, 166, 111, 158, 216, 56, 13, 94, 181, 149, 139, 134, 20, 83, 5, 116, 65, 255, 59, 40, 70, 234, 195, 34, 209, 4, 20, 40, 49, 132, 152, 93, 124, 44, 100, 195, 81, 92, 254, 59, 105, 68, 1, 107, 45, 25, 30, 127, 115, 39, 199, 167, 103, 220, 17, 169, 198, 44 } });

            migrationBuilder.InsertData(
                table: "PersonagemHabilidades",
                columns: new[] { "HabilidadeId", "PersonagemId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 3 },
                    { 3, 4 },
                    { 1, 5 },
                    { 2, 6 },
                    { 3, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonagemHabilidades_HabilidadeId",
                table: "PersonagemHabilidades",
                column: "HabilidadeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonagemHabilidades");

            migrationBuilder.DropTable(
                name: "Habilidades");

            migrationBuilder.DropColumn(
                name: "Derrotas",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "Disputas",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "Vitorias",
                table: "Personagens");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 200, 248, 80, 64, 205, 129, 99, 181, 58, 189, 44, 128, 194, 180, 244, 21, 29, 218, 66, 207, 38, 67, 216, 56, 251, 135, 52, 228, 248, 3, 0, 137, 223, 80, 252, 37, 201, 21, 252, 67, 201, 94, 178, 170, 133, 236, 176, 231, 27, 15, 72, 106, 153, 211, 21, 205, 212, 18, 132, 252, 130, 196, 72, 155 }, new byte[] { 97, 240, 202, 188, 49, 61, 149, 155, 165, 224, 202, 75, 207, 117, 85, 34, 39, 111, 65, 208, 91, 15, 79, 145, 30, 8, 122, 26, 52, 38, 130, 3, 132, 114, 46, 151, 243, 209, 194, 169, 220, 94, 202, 79, 177, 50, 99, 247, 70, 137, 231, 148, 158, 71, 174, 172, 14, 119, 136, 172, 70, 91, 60, 19, 81, 154, 229, 170, 159, 101, 103, 16, 245, 185, 161, 157, 19, 188, 27, 44, 56, 249, 34, 226, 231, 228, 102, 97, 56, 152, 181, 93, 166, 43, 104, 183, 209, 143, 64, 132, 197, 54, 64, 48, 244, 169, 208, 237, 151, 177, 18, 245, 105, 8, 218, 79, 192, 145, 126, 91, 90, 12, 96, 39, 32, 1, 73, 84 } });
        }
    }
}
