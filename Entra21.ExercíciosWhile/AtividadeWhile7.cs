using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExercíciosWhile
{
    internal class AtividadeWhile7
    {
        public void Executar()
        {
            //7. Solicite o nome, valor, quantidade enquanto a quantidade de produtos for menor que
            //5.Ao final deve-se aplicar um desconto de R$ 150,00.

            string nome = "";
            double valor = 0;
            int indice = 0;
            double quantidadeProdutos = 0;
            

            while(indice < 5)
            {
                Console.Write("Digite o nome do produto: ");
                nome = Console.ReadLine();
                Console.Write("Digite o valor do produto: ");
                valor = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite a quantidade de produtos: ");
                quantidadeProdutos = Convert.ToDouble(Console.ReadLine());
                indice = indice + 1;
                
            }

            double multiplicacao = Convert.ToDouble(quantidadeProdutos * valor);
            double desconto = 150;
            valor = desconto - valor;


            Console.Write("O valor do produto é: " + valor );
        }
    }
}
