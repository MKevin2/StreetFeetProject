using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projeto3DS.Migrations
{
    /// <inheritdoc />
    public partial class PopCategoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into Categoria(categoria_nome, desc) values ('Nike', 'Tênis com as tecnologias Nike')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from Categoria");
        }
    }
}
