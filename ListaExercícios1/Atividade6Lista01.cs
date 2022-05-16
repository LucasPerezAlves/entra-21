using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.AtividadeLista1
{
    internal class Atividade6Lista01
    {
        public void Executar()
        {
            //            6.Calcule a quantidade de litros de água ingeridos em determinado período e o valor pago.
            //            Para tal deve - se solicitar ao usuário a média da quantidade de litros ingeridos por dia,
            //            a quantidade de anos e o valor pago pela água.
            //  Exemplo: 
            //Quantidade de litros: 3
            //Quantidade de anos consumidos: 17
            //Valor por Litro: R$ 9.75
            //Quantidade de Litros consumidos: 18.615 L
            // Valor Total Pago: R$ 181.496, 25


            Console.Write("Digite a quantidade média de litros ingeridos por dia: ");
            int litrosAgua = Convert.ToInt32(Console.ReadLine());
            Console.Write("Por quantos anos você ingeriu essa média de litros: ");
            int anosConsumidos = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o valor pago pela água: $ ");
            double valorPorLitro = Convert.ToDouble(Console.ReadLine());

            double litrosConsumidos = litrosAgua * anosConsumidos;
            double valorTotalPago = valorPorLitro * anosConsumidos;

            Console.WriteLine("A quantidade de litros consumidos é: " + (litrosAgua * anosConsumidos));
            Console.Write("O valor total pago é: $ " + (valorPorLitro * anosConsumidos));

        }
    }
}
