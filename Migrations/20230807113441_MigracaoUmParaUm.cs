using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoUmParaUm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonagemId",
                table: "Armas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 1,
                column: "PersonagemId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 2,
                column: "PersonagemId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 3,
                column: "PersonagemId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 4,
                column: "PersonagemId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 5,
                column: "PersonagemId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 6,
                column: "PersonagemId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 7,
                column: "PersonagemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 200, 248, 80, 64, 205, 129, 99, 181, 58, 189, 44, 128, 194, 180, 244, 21, 29, 218, 66, 207, 38, 67, 216, 56, 251, 135, 52, 228, 248, 3, 0, 137, 223, 80, 252, 37, 201, 21, 252, 67, 201, 94, 178, 170, 133, 236, 176, 231, 27, 15, 72, 106, 153, 211, 21, 205, 212, 18, 132, 252, 130, 196, 72, 155 }, new byte[] { 97, 240, 202, 188, 49, 61, 149, 155, 165, 224, 202, 75, 207, 117, 85, 34, 39, 111, 65, 208, 91, 15, 79, 145, 30, 8, 122, 26, 52, 38, 130, 3, 132, 114, 46, 151, 243, 209, 194, 169, 220, 94, 202, 79, 177, 50, 99, 247, 70, 137, 231, 148, 158, 71, 174, 172, 14, 119, 136, 172, 70, 91, 60, 19, 81, 154, 229, 170, 159, 101, 103, 16, 245, 185, 161, 157, 19, 188, 27, 44, 56, 249, 34, 226, 231, 228, 102, 97, 56, 152, 181, 93, 166, 43, 104, 183, 209, 143, 64, 132, 197, 54, 64, 48, 244, 169, 208, 237, 151, 177, 18, 245, 105, 8, 218, 79, 192, 145, 126, 91, 90, 12, 96, 39, 32, 1, 73, 84 } });

            migrationBuilder.CreateIndex(
                name: "IX_Armas_PersonagemId",
                table: "Armas",
                column: "PersonagemId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Armas_Personagens_PersonagemId",
                table: "Armas",
                column: "PersonagemId",
                principalTable: "Personagens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Armas_Personagens_PersonagemId",
                table: "Armas");

            migrationBuilder.DropIndex(
                name: "IX_Armas_PersonagemId",
                table: "Armas");

            migrationBuilder.DropColumn(
                name: "PersonagemId",
                table: "Armas");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 128, 158, 154, 200, 53, 98, 41, 49, 177, 87, 236, 20, 50, 138, 168, 232, 148, 140, 244, 254, 38, 57, 53, 215, 76, 139, 47, 156, 174, 147, 62, 78, 65, 143, 17, 146, 14, 121, 150, 235, 213, 247, 34, 173, 185, 98, 145, 179, 131, 125, 146, 184, 127, 213, 194, 31, 214, 120, 227, 138, 60, 162, 72, 95 }, new byte[] { 109, 55, 19, 236, 138, 189, 123, 93, 151, 205, 56, 25, 61, 185, 98, 118, 223, 218, 83, 148, 87, 127, 65, 190, 176, 133, 245, 73, 187, 233, 163, 102, 151, 121, 238, 201, 141, 90, 139, 226, 136, 230, 222, 233, 158, 188, 242, 2, 70, 131, 52, 197, 18, 98, 43, 105, 243, 69, 74, 215, 116, 251, 53, 52, 154, 88, 54, 199, 173, 24, 197, 143, 182, 167, 250, 239, 116, 37, 4, 252, 66, 151, 97, 76, 43, 124, 196, 87, 198, 84, 104, 188, 180, 140, 115, 238, 13, 244, 60, 138, 91, 19, 186, 94, 79, 226, 9, 59, 67, 169, 236, 194, 146, 65, 100, 175, 61, 150, 44, 241, 123, 180, 118, 17, 232, 12, 48, 179 } });
        }
    }
}
