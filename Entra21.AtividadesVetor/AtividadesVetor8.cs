using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.AtividadesVetor
{
    internal class AtividadesVetor8
    {
        public void Executar()
        {

            var numeroPar = 0;
           

            int[] numeros = new int[10];

            for (var i = 0; i < numeros.Length; i++)
            {
                var numeroValido = false;
                while (numeroValido == false)
                {
                    try
                    {
                        Console.WriteLine("Digite o " + (i + 1) + "º numero:");
                        numeros[i] = Convert.ToInt32(Console.ReadLine());
                        
                        numeroValido = true;
                    }
                    catch
                    {
                        Console.WriteLine("Numero inválido");
                    }

                    if (numeroPar % 2 == 0)
                    {
                        numeroPar = numeros[i];
                        numeroValido = false;
                    }
                   
                }
            }
            Console.Clear();
            Console.WriteLine("Os números pares são: " + numeroPar);
        }
    }
}
