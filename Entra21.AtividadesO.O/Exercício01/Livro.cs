using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.AtividadesOrientacaoObjetos
{
    public class Livro
    {
        public string Titulo;
        public string Autor;
        public string CodeIsbn;
        public string idiomaOriginal;
        public DateTime DataLancamento;
        public int QuantidadePaginas;
        public int QuantidadePaginasLidas;
        public int QuantidadeReleituras;

        public void ApresentarTituloAutor()
        {
            Console.WriteLine($"Nome do titulo é: {Titulo}" + 
                $"\n O autor é:  {Autor}");
            
        }
        
        public int QuantidadePaginasParaLer()
        {

            var quantidadePaginasLidas = QuantidadePaginasLidas;
            var quantidadePaginasTotalLivro =  QuantidadePaginas;

            return (quantidadePaginasTotalLivro - quantidadePaginasLidas);

            Console.WriteLine($"A quantidade de páginas que precisa ler é: {QuantidadePaginasParaLer()}");
        }

        public int QuantidadePaginasLidaTotal()
        {
            var releitura = QuantidadeReleituras;
            var quantidadeLidasTotal = releitura * QuantidadePaginas + QuantidadePaginasLidas;

            if (QuantidadeReleituras > 0)
            {
                return quantidadeLidasTotal;
            }

            return QuantidadePaginasLidas;

            Console.WriteLine("A quantidade de pa");
        }

        public DateTime QuantidadeAnosAposPublicacao()
        {

            var anoLancamento = DataLancamento.Year;

        }
    }
}
