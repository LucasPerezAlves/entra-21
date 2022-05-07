using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExercíciosWhile
{
    internal class AtividadeWhile6
    {
        public void Executar()
        {
            //6. Solicite o nome, valor e a quantidade de produtos, enquanto o nome for diferente de sair
            //ao final deve-se aplicar ao valor total da compra um desconto de 5%. 

            string nome = "";
            int quantidade = 0;
            double valor = 0;
            int indice = 0;

            while (nome != "sair")
            {
                Console.Write("Digite o seu nome: ");
                nome = Console.ReadLine();

                while (nome != "sair")
                {
                    Console.Write("Digite a quantidade do produto: ");
                    quantidade = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Digite o valor: ");
                    valor = Convert.ToDouble(Console.ReadLine());
                    indice = indice + 1;
                    Console.Write("Digite o seu nome: ");
                    nome = Console.ReadLine();

                    
                }

            }

        }
    }
}

       
