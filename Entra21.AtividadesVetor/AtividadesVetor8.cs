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
            var numeroDigitado = 0;

            int[] numeros = new int[10];

            for (var i = 0; i < numeros.Length; i++)
            {
                var numeroValido = false;
                while (numeroValido == false)
                {

                    try
                    {
                        Console.WriteLine("Digite o " + (i + 1) + "º numero:");
                        numeroDigitado= Convert.ToInt32(Console.ReadLine());

                    }
                    catch
                    {
                        Console.WriteLine("Numero inválido");
                    }

                    if (numeroDigitado % 2 == 0)
                    {
                        numeros[i] = numeroDigitado;
                        numeroValido = true;
                    }

                }
            }
            Console.Clear();
            Console.WriteLine("Os números pares são: " + numeroPar);
        }
    }
}
