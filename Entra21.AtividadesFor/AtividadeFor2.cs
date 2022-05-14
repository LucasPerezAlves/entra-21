using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.AtividadesFor
{
    internal class AtividadeFor2
    {
        public void Executar()
        {
            //     Faça um programa que solicite a quantidade de carros que o usuário deseja cadastrar,
            //     após isto solicite para o usuário o modelo, valor e ano do carro *até* que
            //     atinja a quantidade de carros para cadastro. Apresente ao final:
            // ● Média do ano dos carros;
            //● Média do valor dos carros;
            //● Quantidade de carros que começam com a letra G;
            //● Quantidade de carros que começam com a letra A.

            Console.Write("Digite a quantidade de carros que deseja cadastrar: ");
            var carrosCadastrados = Convert.ToInt32(Console.ReadLine());

            var somaAno = 0;
            var somaValor = 0.0;
            var mediaValor = 0.0;
            var mediaAno = 0;
            var quantidadeComecaG = 0;
            var quantidadeComecaA = 0;

            for (var i = 0; i < carrosCadastrados; i = i + 1)
            {
                Console.WriteLine("Digite o modelo do carro: ");
                var modelo = Console.ReadLine().ToLower().Trim();
                Console.WriteLine("Digite o ano do carro: ");
                var ano = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o valor do carro: ");
                var valor = Convert.ToDouble(Console.ReadLine());

                somaValor = somaValor + valor;
                somaAno = somaAno + ano;
                mediaValor = somaValor / carrosCadastrados;
                mediaAno = somaAno / carrosCadastrados;

                if (modelo.StartsWith("a"))
                {
                    quantidadeComecaA = quantidadeComecaA + 1;
                }
                else if (modelo.StartsWith("g"))
                {
                    quantidadeComecaG = quantidadeComecaG + 1;
                }

                Console.WriteLine("A média do valor dos carros é: " + mediaValor + 
                   "\nA média dos anos dos carros é: " + mediaValor +
                   "\nA quantidade de carros que começam com a letra A é de: " + quantidadeComecaA + 
                   "\nA quantidade de carros que começam com a letra G é de: " + quantidadeComecaG);


            }



        }
    }
}
