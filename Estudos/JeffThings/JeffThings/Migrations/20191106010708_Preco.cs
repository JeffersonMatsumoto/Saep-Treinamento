using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JeffThings.Migrations
{
    public partial class Preco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PLATAFORMAS",
                columns: table => new
                {
                    ID = table.Column<byte>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NOME = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PLATAFORMAS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TIPOS_JOGOS",
                columns: table => new
                {
                    ID = table.Column<byte>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NOME = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TIPOS_JOGOS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "USUARIOS",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EMAIL = table.Column<string>(unicode: false, maxLength: 250, nullable: false),
                    SENHA = table.Column<string>(unicode: false, maxLength: 250, nullable: false),
                    NOME = table.Column<string>(unicode: false, maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USUARIOS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "JOGOS",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NOME = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    DATA_LANCAMENTO = table.Column<DateTime>(type: "date", nullable: false),
                    DESCRICAO = table.Column<string>(type: "text", nullable: false),
                    PRECO = table.Column<decimal>(type: "smallmoney", nullable: false),
                    COOP = table.Column<bool>(nullable: false),
                    TIPOS_JOGOS_ID = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JOGOS", x => x.ID);
                    table.ForeignKey(
                        name: "FK__JOGOS__TIPOS_JOG__59063A47",
                        column: x => x.TIPOS_JOGOS_ID,
                        principalTable: "TIPOS_JOGOS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "JOGOS_PLATAFORMAS",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ID_JOGO = table.Column<int>(nullable: false),
                    ID_PLATAFORMA = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JOGOS_PLATAFORMAS", x => x.ID);
                    table.ForeignKey(
                        name: "FK__JOGOS_PLA__ID_JO__60A75C0F",
                        column: x => x.ID_JOGO,
                        principalTable: "JOGOS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__JOGOS_PLA__ID_PL__619B8048",
                        column: x => x.ID_PLATAFORMA,
                        principalTable: "PLATAFORMAS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "UQ__JOGOS__E2AB1FF4595C6044",
                table: "JOGOS",
                column: "NOME",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_JOGOS_TIPOS_JOGOS_ID",
                table: "JOGOS",
                column: "TIPOS_JOGOS_ID");

            migrationBuilder.CreateIndex(
                name: "IX_JOGOS_PLATAFORMAS_ID_JOGO",
                table: "JOGOS_PLATAFORMAS",
                column: "ID_JOGO");

            migrationBuilder.CreateIndex(
                name: "IX_JOGOS_PLATAFORMAS_ID_PLATAFORMA",
                table: "JOGOS_PLATAFORMAS",
                column: "ID_PLATAFORMA");

            migrationBuilder.CreateIndex(
                name: "UQ__USUARIOS__161CF72416821025",
                table: "USUARIOS",
                column: "EMAIL",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JOGOS_PLATAFORMAS");

            migrationBuilder.DropTable(
                name: "USUARIOS");

            migrationBuilder.DropTable(
                name: "JOGOS");

            migrationBuilder.DropTable(
                name: "PLATAFORMAS");

            migrationBuilder.DropTable(
                name: "TIPOS_JOGOS");
        }
    }
}
