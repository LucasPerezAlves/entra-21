using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosWhile
{
    internal class Exemplo03
    {
        public void Executar()
        {
            string nome = "";
            int indice = 0;
            while (nome != "fim")
            {
                Console.Write("Digite um nome: ");
                nome = Console.ReadLine().ToLower().Trim();
                indice = indice + 1;
                Console.Write("oi: ");
            }
        }
    }
}
