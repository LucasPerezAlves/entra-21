using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExercíciosWhile
{
    internal class AtividadeWhile10
    {
        public void Executar()
        {
            int indice = 0;
            int numero = 0;
            int resultado = 0;
            int indice2 = 0;

            Console.WriteLine("Digite um número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            int ordemCrescente = numero;
            int ordemDecrescente = numero;



            Console.WriteLine("Os 50 números antecessores pares são: ");
                
            while(indice < 50)
            {
                ordemDecrescente = ordemDecrescente - 1;

                if (ordemDecrescente % 2 == 0)
                {
                 
                    Console.WriteLine(ordemDecrescente);
                    
                }
                indice = indice + 1;
            }
            Console.WriteLine("Os 50 números sucessores ímpares são: ");

            while (indice2 < 50)
            {
                ordemCrescente = ordemCrescente + 1;
                if (ordemCrescente % 2 != 0)
                {
                    Console.WriteLine(ordemCrescente);
                    
                }
                indice2 = indice2 + 1;
            }
        }
    }
}
