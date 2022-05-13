using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.AtividadeLista1
{
    internal class Atividade3Lista01
    {
        public void Executar()
        {
            Console.Write("Digite a sua altura: ");
            int altura = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o seu peso: ");
            double peso = Convert.ToDouble((Console.ReadLine()));
            double imc = peso / (altura * altura);
            Console.Write("O seu IMC é de: " + imc);
        }
    }
}
