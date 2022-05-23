using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.AtividadesVetor
{
    internal class AtividadesVetor6
    {
        public void Executar()
        {
            int[] idades = new int[9];

            int idadeMaior = int.MinValue;

            for(var i = 0; i < idades.Length; i++)
            {
                Console.WriteLine("Digite a " + (i + 1) + "° idade");
                idades[i] = Convert.ToInt32(Console.ReadLine());

                if(idades[i] > idadeMaior)
                {
                    idadeMaior =  idades[i];
                    
                }

            }
            Console.WriteLine("A maior idade digitada é: " + idadeMaior);
        }
    }
}
