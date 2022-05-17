using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.AtividadesFor
{
    internal class AtividadeFor12while
    {
        public void Executar()
        {


            var quantidadeBolos = 0;
            var quantidadeDoces = 0;
            var quantidadeSanduiches = 0;
            var quantidadePizza = 0;
            var media = 0.0;
            var valor = 0.0;
            var codigoPedido = 0;
            var quantidadePedidos = 0;

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

            try
            {
                Console.WriteLine("Digite a quantidade de pedidos: ");
               quantidadePedidos = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Modelo digitado é inválido");
            }
           

            //quantidade de cada coisa

            for (var i = 0; i < quantidadePedidos; i = i + 1)
            {
                try
                {
                    Console.WriteLine("Digite o numero do seu pedido: ");
                    codigoPedido = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Modelo digitado é inválido");
                }

                if ((codigoPedido == 1) || (codigoPedido == 2) || (codigoPedido == 3) || (codigoPedido == 4) || (codigoPedido == 5))
                {
                    quantidadeBolos = quantidadeBolos + 1;
                }
                else if ((codigoPedido == 6) || (codigoPedido == 7))
                {
                    quantidadeDoces = quantidadeDoces + 1;
                }
                else if ((codigoPedido == 8) || (codigoPedido == 9) || (codigoPedido == 10) || (codigoPedido == 11))
                {
                    quantidadeSanduiches = quantidadeSanduiches + 1;
                }
                else if ((codigoPedido == 12) || (codigoPedido == 13) || (codigoPedido == 14) || (codigoPedido == 15))
                {
                    quantidadePizza = quantidadePizza + 1;
                }
                //valor total

                if (codigoPedido == 1)
                {
                    valor = valor + 29.50;
                }
                else if (codigoPedido == 2)
                {
                    valor = valor + 2.00;
                }
                else if (codigoPedido == 3)
                {
                    valor = valor + 29.13;
                }
                else if (codigoPedido == 4)
                {
                    valor = valor + 7.10;
                }
                else if (codigoPedido == 5)
                {
                    valor = valor + 19.33;
                }
                else if (codigoPedido == 6)
                {
                    valor = valor + 17.71;
                }
                else if (codigoPedido == 7)
                {
                    valor = valor + 4.82;
                }
                else if (codigoPedido == 8)
                {
                    valor = valor + 21.16;
                }
                else if (codigoPedido == 9)
                {
                    valor = valor + 12.70;
                }
                else if (codigoPedido == 10)
                {
                    valor = valor + 19.70;
                }
                else if (codigoPedido == 11)
                {
                    valor = valor + 28.22;
                }
                else if (codigoPedido == 12)
                {
                    valor = valor + 8.98;
                }
                else if (codigoPedido == 13)
                {
                    valor = valor + 0.42;
                }
                else if (codigoPedido == 14)
                {
                    valor = valor + 18.36;
                }
                else if (codigoPedido == 15)
                {
                    valor = valor + 27.50;
                }




                //Média dos produtos


                media = valor / quantidadePedidos;

            }
            Console.WriteLine(@"Quantidade de bolos escolhidos é: " + quantidadeBolos +
           " \nA quantidade de doces escolhidos é: " + quantidadeDoces +
           "\nA quantidade de sanduíches escolhidos é: " + quantidadeSanduiches +
           "\nA quantidade de pizzas escolhidas é: " + quantidadePizza +
           "\nO valor total da comanda: R$" + valor +
           "\nO valor total da quantidade de pedidos é: " + codigoPedido +
           "\nA média do valor dos produtos é: " + media);
        }
    }
}
