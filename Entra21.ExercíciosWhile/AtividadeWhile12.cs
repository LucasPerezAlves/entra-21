using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExercíciosWhile
{
    internal class AtividadeWhile12
    {
        public void Executar()
        {

           
            int pedido = 0;
            int quantidadePedidos = 0;
            double valorTotal = 0;
            int bolo = 0;
            int doce = 0;
            int sanduiche = 0;
            int pizza = 0;

            while (pedido != 16)
            {
                quantidadePedidos = quantidadePedidos + 1;

                Console.Write("Esse é o cardápio senhor: ");


                Console.WriteLine(@"
  Menu
Código  |  tipos    | Nome                        | valor
 1      | bolos     | Bolo Brigadeiro             | R$ 29,50 
 2      | bolos     | Bolo Floresta Negra         | R$ 2,00
 3      | bolos     | Bolo Leite com Nuttela      | R$ 29,23
 4      | bolos     | Bolo Mousse com Chocolate   | R$ 7,10
 5      | bolos     | Bolo Nega Maluca            | R$ 19,33
 6      | Doces     | Bomba de Creme              | R$ 17,71
 7      | Doces     | Bomba de Morango            | R$ 4,82
 8      | Sanduíches| Filé-Mignon com fritas e    | R$ 21,16
                      chedder
 9      | Sanduíches| Hamburguer com queijos,     | R$ 12,70
                      Champignon e rúcula
 10     | Sanduíches| Provolone com salame        | R$ 19,70
 11     | Sanduíches| Vegetariano com Berinjela   | R$ 28,22
 12     | Pizzas    | Calabresa                   | R$ 8,98
 13     | Pizzas    | Napolitana                  | R$ 0,42
 14     | Pizzas    | Peruana                     | R$ 18,36
 15     | Pizzas    | Portuguesa                  | R$ 27,50
 16     | Sair      |                             |");

                

                Console.Write("Digite o número do seu pedido: ");
                pedido = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                


                //quantidade pedidos

                if ((pedido == 1) || (pedido == 2) || (pedido == 3) || (pedido == 4) || (pedido == 5))
                {
                    bolo = bolo + 1;

                }
                else if ((pedido == 6) || (pedido == 7) )
                {
                    doce = doce + 1;
                }
                else if ((pedido == 8) || (pedido == 9) || (pedido == 10) || (pedido == 11))
                {
                    sanduiche = sanduiche + 1;
                }
                else if ((pedido == 12) || (pedido == 13) || (pedido == 14))
                {
                    pizza = pizza + 1;
                }

                //valor total
                
                if(pedido == 1)
                {
                    valorTotal = valorTotal + 29.50;
                }
                else if(pedido == 2)
                {
                    valorTotal = valorTotal + 2.00;
                }
                else if(pedido == 3)
                {
                    valorTotal = valorTotal + 29.23; 
                }
                else if (pedido == 4)
                {
                    valorTotal = valorTotal + 7.10;
                }
                else if (pedido == 5)
                {
                    valorTotal = valorTotal + 19.33;
                }
                else if (pedido == 6)
                {
                    valorTotal = valorTotal + 17.71;
                }
                else if (pedido == 7)
                {
                    valorTotal = valorTotal + 4.82;
                }
                else if (pedido == 8)
                {
                    valorTotal = valorTotal + 21.16;
                }
                else if (pedido == 9)
                {
                    valorTotal = valorTotal + 12.70;
                }
                else if (pedido == 10)
                {
                    valorTotal = valorTotal + 19.70;
                }
                else if (pedido == 11)
                {
                    valorTotal = valorTotal + 28.22;
                }
                else if (pedido == 12)
                {
                    valorTotal = valorTotal + 8.98;
                }
                else if (pedido == 13)
                {
                    valorTotal = valorTotal + 0.42;
                }
                else if (pedido == 14)
                {
                    valorTotal = valorTotal + 18.36;
                }
                else if (pedido == 15)
                {
                    valorTotal = valorTotal + 27.50;
                }
            }

            double media = valorTotal / quantidadePedidos;

            Console.Write(@"Quantidade de bolos escolhidos é: " + bolo +
               " \nA quantidade de doces escolhidos é: " + doce +
               "\nA quantidade de sanduíches escolhidos é: " + sanduiche +
               "\nA quantidade de pizzas escolhidas é: " + pizza +
               "\nO valor total da comanda: R$" + valorTotal +
               "\nO valor total da quantidade de pedidos é: " + quantidadePedidos +
               "\nA média do valor dos produtos é: " + media);




            

        }
    }
}
