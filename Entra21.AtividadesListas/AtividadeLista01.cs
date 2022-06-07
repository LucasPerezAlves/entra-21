using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.AtividadesListas
{
    public class AtividadeLista01
    {
        public void Executar()
        {
            List<string> filmes = new List<string>();
            filmes.Add("Dragon Ball Evolution");
            filmes.Add("Titanic");
            filmes.Add("Lanterna Verde");

            Console.WriteLine("[0]" + filmes[0] +
                "\n[1]" + filmes[1] +
                "\n[2]" + filmes[2]);

            filmes.Add("");

            filmes[0] = "Dragon Ball Super: Broly";

            filmes.RemoveAt(2);

            var contemLanterna = filmes.Contains("Lanterna Verde");

            if (contemLanterna == true)
            {
                Console.WriteLine("não existe esse filme");
            }
            else
            {
                Console.WriteLine("Existe esse filme!!");
            }

            filmes.Add("Quarteto Fantástico");

            Console.WriteLine("[0]" + filmes[0] +
                "\n[1]" + filmes[1] +
                "\n[2]" + filmes[2]);

            filmes[1] = "Titanic 2";

            Console.WriteLine("[0]" + filmes[0] +
                "\n[1]" + filmes[1] +
                "\n[2]" + filmes[2] +
                "\n[3]" + filmes[3]);

            var existeLagoa = filmes.Contains("Lagoa Azul");

            if(existeLagoa == true)
            {
                Console.WriteLine("Existe Lagoa Azul");
            }
            else
            {
                Console.WriteLine("não existe lagoa");
            }

        }

    }
}
