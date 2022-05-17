using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.AtividadesFor
{
    internal class AtividadeFor13while
    {
        public void Executar()
        {
            for (var i = 0; i < 22; i = i + 1)
            {
                Console.WriteLine("Digite o seu nome: ");
                var nome = Console.ReadLine();
                Console.WriteLine("Digite a sua idade: ");
                var idade = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o seu peso: ");
                var peso = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o seu sexo: ");
                var sexo = Console.ReadLine().Trim();
                Console.WriteLine("Digite a quantidade de gols marcados: ");
                var quantidadeGols = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite a quantidade de amarelos recebidos: ");
                var quantidadeAmarelos = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite a quantidade de vermelhos recebidos: ");
                var quantidadeVermelhos = Convert.ToInt32(Console.ReadLine());
                Console.Clear();




            }
        }
    }
}
