using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    public partial class PopularLanches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [Lanches] ([Nome],[DescricaoCurta],[DescricaoDetalhada],[Preco],[ImagemUrl],[ImagemThumbnailUrl],[IsLanchePreferido],[EmEstoque],[CategoriaId]) VALUES ('Cheese Salada', 'Pão, hambúrguer, ovo, presunto, queijo e batata palha', 'Delicioso pão de hamburguer com ovo frito; presunto e queijo de primeira qualidade acompanhado com batata palha', 12.50, 'https://www.macoratti.com.net/Imagens/lanches/cheesesalada1.jpg', 'https://www.macoratti.com.net/Imagens/lanches/cheesesalada1.jpg', 0, 1, 1)");
            migrationBuilder.Sql("INSERT INTO [Lanches] ([Nome],[DescricaoCurta],[DescricaoDetalhada],[Preco],[ImagemUrl],[ImagemThumbnailUrl],[IsLanchePreferido],[EmEstoque],[CategoriaId]) VALUES ('Misto Quente', 'Pão, queijo, presunto e manteiga', 'Delicioso misto com queijo, presunto e manteiga', 8.00,'https://www.macoratti.com.net/Imagens/lanches/mistoquente.jpg','https://www.macoratti.com.net/Imagens/lanches/mistoquente.jpg', 0, 1, 1)");
            migrationBuilder.Sql("INSERT INTO [Lanches] ([Nome],[DescricaoCurta],[DescricaoDetalhada],[Preco],[ImagemUrl],[ImagemThumbnailUrl],[IsLanchePreferido],[EmEstoque],[CategoriaId]) VALUES ('Cheese Burguer', 'Pão, hambúrguer, ovo, presunto, alface, tomate, queijo e batata palha', 'Delicioso pão de hamburguer com ovo frito; presunto e queijo de primeira qualidade acompanhado com tomate e alface', 11.00,'https://www.macoratti.com.net/Imagens/lanches/cheeseburguer.jpg','https://www.macoratti.com.net/Imagens/lanches/cheeseburguer.jpg', 0, 1, 1)");
            migrationBuilder.Sql("INSERT INTO [Lanches] ([Nome],[DescricaoCurta],[DescricaoDetalhada],[Preco],[ImagemUrl],[ImagemThumbnailUrl],[IsLanchePreferido],[EmEstoque],[CategoriaId]) VALUES ('Lanche Natural Peito de Peru', 'Pão, peito de peru, alface, tomate e ricota', 'Delicioso sanduiche natural de peito de peru, com tomate, alface, cenoura e queijo de ricota', 15.00,'https://www.macoratti.com.net/Imagens/lanches/lanchenatural.jpg','https://www.macoratti.com.net/Imagens/lanches/lanchenatural.jpg', 1, 1, 2)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");
        }
    }
}
