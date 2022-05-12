using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExercíciosWhile
{
    internal class AtividadeWhile13
    {
        public void Executar()
        {
            string nome = "";
            int idade = 0;
            double peso = 0;
            string sexo = "";
            int sexoFeminino = 0;
            int sexoMasculino = 0;
            int altura = 0;
            int quantidadeGols = 0;
            int quantidadeAmarelos = 0;
            int quantidadeVermelhos = 0;
            int indice = 0;

            while (indice < 22)
            {
                Console.Write("Digite o nome do jogador: ");
                nome = Console.ReadLine();
                Console.Write("Digite a idade do jogador: ");
                idade = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite o peso do jogador: ");
                peso = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite o sexo do jogador: ");
                sexo = Console.ReadLine();
                Console.Write("Digite a altura do jogador: ");
                altura = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite a quantidade de gols que ele marcou: ");
                quantidadeGols = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite a quantidade de cartões amarelos recebidos: ");
                quantidadeAmarelos = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite a quantidade de cartões vermelhos recebidos: ");
                quantidadeVermelhos = Convert.ToInt32(Console.ReadLine());


                if (sexo.EndsWith("a"))
                {
                    sexoFeminino = sexoFeminino + 1;
                }
                else if (sexo.EndsWith("o"))
                {
                    sexoFeminino = sexoFeminino + 1;
                }


                if (peso < 40)
                {

                }
            }
        }
    }
}
