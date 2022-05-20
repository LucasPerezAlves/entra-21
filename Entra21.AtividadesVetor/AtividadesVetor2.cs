using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.AtividadesVetor
{
    internal class AtividadesVetor2
    {
        public void Executar()
        {
            string[] nomes = new string[10];

           for (var i = 0; i < nomes.Length; i = i + 1)
            {
                Console.WriteLine("Digite o seu nome: ");
                nomes[i] = Console.ReadLine();
                
            }
            Console.WriteLine("Os nomes armazenados foram: " + nomes[0] + ", " + nomes[1] + ", " + nomes[2] + ", " + nomes[3] + ", " + nomes[4] + ", " + nomes[5] + ", " + nomes[6] 
                + ", " +  nomes[7] + ", " + nomes[8] + ", " + nomes[9]);
        }
    }
}
