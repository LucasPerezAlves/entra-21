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
        
        public int quantidadePaginasParaLer()
        { 

            Console.WriteLine($"A quantidade de páginas que você precisa ler é: {QuantidadePaginas - QuantidadePaginasLidas}");
            QuantidadePaginasLidas = Convert.ToInt32(Console.ReadLine());

            return QuantidadePaginasLidas;
        }

        public void QuantidadePaginasLidaTotal()
        {
            QuantidadeReleituras = QuantidadePaginasLidas + QuantidadePaginasLidas;
           
        }
    }
}
