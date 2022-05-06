using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExercíciosWhile
{
    internal class AtividadeWhile4
    {
        public void Executar()
        {
            //4.Solicite o peso para o usuário até que o peso seja menor que 0 ou maior que 300,00.Apresentar ao final a quantidade de pessoas que informaram o peso

            double peso = 0;
            int quantidadesPessoasPeso = 0;

            while ((peso > -1) && (peso < 301))
            {

                Console.Write("Digite o seu peso: ");
                peso = Convert.ToInt32(Console.ReadLine());
                quantidadesPessoasPeso = quantidadesPessoasPeso + 1;

            }
            Console.WriteLine("A quantidade de pessoas: " + quantidadesPessoasPeso);


        }
    }
}
