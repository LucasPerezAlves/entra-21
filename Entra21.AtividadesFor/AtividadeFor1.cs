using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.AtividadesFor
{
    internal class AtividadeFor1
    {
        public void Executar()
        {
            for (var i = 0; i < 13; i = i + 1)
            {
                Console.WriteLine("Digite o nome da peça: ");
                var nome = Console.ReadLine();
            }
        }
    }
}
