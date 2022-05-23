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

            for (var i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("Digite o" + (i + 1) + "º nome");
                nomes[i] = Console.ReadLine();
            }
            vetores[0] = nomes[4];
            vetores[1] = nomes[3];
            vetores[2] = nomes[2];
            vetores[3] = nomes[1];

            for (var i = 0; i < vetores.Length; i++)
            {
                vetores[0] = (nomes[nomes.Length - 1] + vetores[i]).ToString();
            }
        }
    }
}
