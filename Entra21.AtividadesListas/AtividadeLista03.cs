using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.AtividadesListas
{
    internal class AtividadeLista03
    {
        public void Executar()
        {
            List<double> numeros = new List<double>();

            Console.WriteLine("Digite a primeira nota: ");
            numeros.Add (Convert.ToDouble(Console.ReadLine()));
            Console.Write("Digite a segunda nota: ");
            numeros.Add(Convert.ToDouble(Console.ReadLine()));
            Console.Write("Digite a terceira nota: ");
            numeros.Add(Convert.ToDouble(Console.ReadLine()));

            Console.Write("primeira nota: " + numeros[0] +
                "\nSegunda nota: " + numeros[1] +
                "\nTerceira nota: " + numeros[2]);

            
            Console.Write("\n\nA média das notas é: " + (numeros[0] + numeros[1] + numeros[2]) / 3);

        }
    }
}
