using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.AtividadesVetor
{
    internal class AtividadesVetor3
    {
        public void Executar()
        {
            string[] nomes = new string[7];
            double[] preco = new double[7];

            for (var i = 0; i < nomes.Length; i = i + 1)
            {
                Console.WriteLine("Digite o nome do[" + (i + 1) + "]produto: ");
                nomes[i] = Console.ReadLine();
                Console.WriteLine("Digite o preço do[" + (i + 1) +"] produto: ");
                preco[i] = Convert.ToDouble(Console.ReadLine());
                
            }

            for (var i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("O produto[" + (i + 1) + "]: "+ nomes[i] + " " + "$" + preco[i]);
            }
        }
    }
}
