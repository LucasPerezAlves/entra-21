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

            var quantidadePedidos = 0;
            var quantidadeBolos = 0;
            var quantidadeDoces = 0;
            var quantidadeSanduiches = 0;
            var quantidadePizza = 0;
            var somaProdutos = 0;
            var valor = 0.0;

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

            Console.WriteLine("Digite a quantidade de pedidos: ");
            quantidadePedidos = Convert.ToInt32(Console.ReadLine());


            //quantidade de cada coisa
            for (var i = 0; i < quantidadePedidos; i = i + 1)
            {
                if ((quantidadePedidos == 1) || (quantidadePedidos == 2) || (quantidadePedidos == 3) || (quantidadePedidos == 4) || (quantidadePedidos == 5))
                {
                    quantidadeBolos = quantidadeBolos + 1;
                }
                else if ((quantidadePedidos == 6) || (quantidadePedidos == 7))
                {
                    quantidadeDoces = quantidadeDoces + 1;
                }
                else if ((quantidadePedidos == 8) || (quantidadePedidos == 9) || (quantidadePedidos == 10) || (quantidadePedidos == 11))
                {
                    quantidadeSanduiches = quantidadeSanduiches + 1;
                }
                else if ((quantidadePedidos == 12) || (quantidadePedidos == 13) || (quantidadePedidos == 14) || (quantidadePedidos == 15))
                {
                    quantidadePizza = quantidadePizza + 1;

                    //valor total

                    if (quantidadePedidos == 1)
                    {
                        valor = valor + 29.50;
                    }
                    else if (quantidadePedidos == 2)
                    {
                        valor = valor + 2.00;
                    }
                    else if (quantidadePedidos == 3)
                    {
                        valor = valor + 29.13;
                    }
                    else if (quantidadePedidos == 4)
                    {
                        valor = valor + 7.10;
                    }
                    else if (quantidadePedidos == 5)
                    {
                        valor = valor + 19.33;
                    }
                    else if (quantidadePedidos == 6)
                    {
                        valor = valor + 17.71;
                    }
                    else if (quantidadePedidos == 7)
                    {
                        valor = valor + 4.82;
                    }
                    else if (quantidadePedidos == 8)
                    {
                        valor = valor + 21.16;
                    }
                    else if (quantidadePedidos == 9)
                    {
                        valor = valor + 12.70;
                    }
                    else if (quantidadePedidos == 10)
                    {
                        valor = valor + 19.70;
                    }
                    else if (quantidadePedidos == 11)
                    {
                        valor = valor + 28.22;
                    }
                    else if (quantidadePedidos == 12)
                    {
                        valor = valor + 8.98;
                    }
                    else if (quantidadePedidos == 13)
                    {
                        valor = valor + 0.42;
                    }
                    else if (quantidadePedidos == 14)
                    {
                        valor = valor + 18.36;
                    }
                    else if (quantidadePedidos == 15)
                    {
                        valor = valor + 27.50;
                    }
                }
            }
        }
    }
}
