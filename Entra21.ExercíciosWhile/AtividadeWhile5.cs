using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExercíciosWhile
{
    internal class AtividadeWhile5
    {
        public void Executar()
        {
            //5.Faça um programa que solicite a quantidade de carros que o usuário deseja cadastrar, após isto solicite para o usuário o modelo, valor e ano do carro até que atinja a quantidade de carros para cadastro.Apresente ao final:

        //● Média do ano dos carros; 
        //● Média do valor dos carros; 
        //● Quantidade de carros que começam com a letra G;
        //● Quantidade de carros que começam com a letra A.

Console.Write("Digite a quantidade de carros que deseja cadastrar: ");
            int quantidadeCarros = Convert.ToInt32(Console.ReadLine());
            int indice = 0;
            double valorCarro = 0;
            double mediaValorCarro = 0;
            int mediaAnoCarro = 0;
            double somaValorCarro = 0;
            int somaAnoCarro = 0;
            int quantidadeCarrosG = 0;
            int quantidadeCarrosA = 0;

            while (indice < quantidadeCarros)
            {
                Console.Write("Digite o modelo do carro: ");
                string modeloCarro = Console.ReadLine().ToLower().Trim();
                Console.Write("Digite o ano do carro: ");
                int ano = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite o valor do carro: ");
                valorCarro = Convert.ToDouble(Console.ReadLine());
                indice = indice + 1;
                somaValorCarro = somaValorCarro + valorCarro;
                somaAnoCarro = somaAnoCarro + ano;
                mediaAnoCarro = somaAnoCarro / quantidadeCarros;

                mediaValorCarro = somaValorCarro / quantidadeCarros;

                if (modeloCarro.StartsWith("g"))
                {
                    quantidadeCarrosG = quantidadeCarrosG + 1;
                }
                else if (modeloCarro.StartsWith("a"))
                {
                    quantidadeCarrosA = quantidadeCarrosA + 1;
                }



            }

            Console.Write("A média dos valores é: " + mediaValorCarro +
                "\nA média dos anos dos carros é: " + mediaAnoCarro +
                "\nA quantidade de carros que começam com G é :" + quantidadeCarrosG +
                "\nA quantidade de carros que começam com A é: " + quantidadeCarrosA);

        }
    }
}
