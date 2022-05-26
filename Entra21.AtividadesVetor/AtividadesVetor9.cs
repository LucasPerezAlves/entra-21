using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.AtividadesVetor
{
    internal class AtividadesVetor9
    {
        public void Executar()
        {
            string[] nomes = new string[4];
            string[] vetores = new string [4];

            for (var i = 0; i < nomes.Length; i = i + 1)
            {
                Console.WriteLine("Digite o " + (i + 1) + "º nome");
                nomes[i] = Console.ReadLine();


                for (var j = 0; j < vetores.Length; j = j++)
                {
                    vetores[j] = nomes[i];
                }
            }
        }
    }
}
