using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.AtividadesVetor
{
    internal class AtividadesVetor5
    {
        public void Executar()
        {
            double[] pesos = new double[5];
            var somaTotal = 0.0;
            var mediaTotal = 0.0;


            for (var i = 0; i < pesos.Length; i++)
            {
                Console.WriteLine("Digite o valor dos pesos: ");
                pesos[i] = Convert.ToDouble(Console.ReadLine());
                somaTotal = somaTotal + pesos[i];
                mediaTotal = somaTotal / pesos.Length;
            }    
            Console.WriteLine("A soma total é: " + somaTotal + "\nA média dos valores é: " + mediaTotal);
        }
    }
}
