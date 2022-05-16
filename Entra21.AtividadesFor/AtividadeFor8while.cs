using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.AtividadesFor
{
    internal class AtividadeFor8while
    {
        public void Executar()
        {

            //8- Solicite um número e apresentar a tabuada do mesmo até 1000.
            var tabuada = 0;
            var result = 0;
            var numero = 0;
            var valorValido = false;

            while (valorValido == false)
            {
                try
                {
                    Console.WriteLine("Digite um número: ");
                    numero = Convert.ToInt32(Console.ReadLine());
                    valorValido = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro na digitação");
                }
            }
            for (var i = 0; i < 1000; i = i + 1)
            {
                tabuada = tabuada + 1;
                result = numero * tabuada;

            Console.WriteLine(numero + "x" + tabuada + "=" + result);
            }
        }
    }
}
