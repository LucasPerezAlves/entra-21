using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosWhile
{
    internal class Exemplo02
    {
        public void Executar()
        {
            int soma = 0, indice = 0, quantidadePostivios = 0;

            while (indice < 3)
            {

                Console.Write("Digite o número: ");
                int numero = Convert.ToInt32(Console.ReadLine());
                if (numero > 0)
                {
                    quantidadePostivios = quantidadePostivios + 1;
                }
                soma = soma + numero;
            }
            Console.WriteLine("soma: " + soma +
                "\nQuantidade de positivos: " + quantidadePostivios);
        }
    }
}
        
    
