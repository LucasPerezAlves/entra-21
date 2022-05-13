using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.AtividadeLista1
{
    internal class Atividade5Lista01
    {
        public void Executar()
        {
            Console.WriteLine("Digite um numero");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("O seu sucessor é: " + (numero + 1) + "\nO seu antecessor é: " + (numero - 1));

        }
    }
}
