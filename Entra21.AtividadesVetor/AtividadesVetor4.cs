using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.AtividadesVetor
{
    internal class AtividadesVetor4
    {
        public void Executar()
        {
            double[] notas = new double[4];
            var materia = "";

            for (var i = 0; i < notas.Length; i++)
            {
               
                Console.WriteLine("Digite a[" + (i + 1) + "]matéria: ");
                materia = Console.ReadLine();
                Console.WriteLine("Digite a sua[" + (i + 1) + "] nota:");
                notas[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("A média das notas é: " + (notas[1] + notas[2] + notas[3] + notas[4])/4);
        }
    }
}
