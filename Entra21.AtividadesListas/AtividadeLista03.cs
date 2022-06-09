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
        }
    }
}
