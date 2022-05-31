using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.AtividadesOrientacaoObjetos.Exercício01
{
    public class ExemploLivro
    {
       public void Executar()
        {
            Livro livro = new Livro();
            livro.Autor = "PerezEscritor";
            livro.Titulo = "As tranças de um careca";
            livro.QuantidadePaginasLidas = 100;
            livro.QuantidadePaginas = 400;
            livro.QuantidadeReleituras = 1;
            livro.DataLancamento = new DateTime(2011, 05, 27);

            livro.ApresentarTituloAutor();

            Console.WriteLine("A quantidade de páginas que falta ler para acabar o livro é: " + livro.QuantidadePaginasParaLer() +
                "\n A quantidade de páginas lidas no total é: " + livro.QuantidadePaginasLidaTotal());

            livro.ApresentarQuantidadeAnosAposPublicacao();

        }
    }
}
