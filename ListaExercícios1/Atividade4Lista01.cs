using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.AtividadeLista1
{
    internal class Atividade4Lista01
    {
        public void Executar()
        {
            Console.WriteLine("Digite o primeiro número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("soma: " + (numero + numero2));
            Console.WriteLine("subtração: " + (numero - numero2));
            Console.WriteLine("multiplicação: " + (numero * numero2));
            Console.WriteLine("Divisão: " + (numero / numero2));

        }
    }
}
