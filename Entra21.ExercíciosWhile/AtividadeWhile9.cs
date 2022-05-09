using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExercíciosWhile
{
    internal class AtividadeWhile9
    {
        public void Executar()
        {
            int numero = 0;
            int indice = 0;
            int resultado = 1;

            Console.WriteLine("Digite um número: ");
            numero = Convert.ToInt32(Console.ReadLine());
            
            while( numero != 1)
            {
                resultado = resultado * numero;
                numero = numero - 1;
            }
            Console.Write("O seu fator é: " + resultado);
        }
        
    }
}
