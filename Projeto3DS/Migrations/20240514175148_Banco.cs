using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace Projeto3DS.Migrations
{
    /// <inheritdoc />
    public partial class Banco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    categoria_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    categoria_nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Descricao = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.categoria_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tenis",
                columns: table => new
                {
                    tenis_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    desc_curta = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    desc_detalhe = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    em_estoque = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    nome = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false),
                    preco = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    img_url = table.Column<string>(type: "longtext", nullable: false),
                    img_miniatura = table.Column<string>(type: "longtext", nullable: false),
                    Categoria = table.Column<string>(type: "longtext", nullable: false),
                    categoria_id = table.Column<int>(type: "int", nullable: false),
                    categoria_id1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tenis", x => x.tenis_id);
                    table.ForeignKey(
                        name: "FK_Tenis_Categoria_categoria_id1",
                        column: x => x.categoria_id1,
                        principalTable: "Categoria",
                        principalColumn: "categoria_id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Tenis_categoria_id1",
                table: "Tenis",
                column: "categoria_id1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tenis");

            migrationBuilder.DropTable(
                name: "Categoria");
        }
    }
}
