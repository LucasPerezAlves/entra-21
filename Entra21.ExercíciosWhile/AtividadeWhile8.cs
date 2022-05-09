using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExercíciosWhile
{
    internal class AtividadeWhile8
    {
        public void Executar()
        {
            int numero = 0;
            int multiplicação = 0;
            int indice = 0;
            int resultado = 0;
            int tabuada = 0;

             Console.Write("Digite um número: ");
            numero = Convert.ToInt32(Console.ReadLine());


            while (indice < 1000)
            {
                indice = indice + 1;
                tabuada = tabuada + 1;
                resultado = numero * tabuada;

            Console.WriteLine(numero + " x " + tabuada + " = " + resultado);
            }
           
        }
    }
}
