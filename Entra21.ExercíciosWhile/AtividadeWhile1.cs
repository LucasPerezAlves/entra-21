using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExercíciosWhile
{
    internal class @AtividadeWhile1
    {
        public void Executar()
        {
            //1 Solicite o preço e nome da peça de 13 peças


            double preco = 0;
            string nome = "";
            int indice = 0;

            while (indice < 13)
            {

                Console.Write("Nome da peça: ");
                nome = Console.ReadLine();
                Console.Write("Digite o preço da peça:");
                preco = Convert.ToDouble(Console.ReadLine());
                indice = indice + 1;
            }

        }
    }
}
