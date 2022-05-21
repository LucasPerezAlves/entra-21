using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.AtividadesVetor
{
    internal class AtividadesVetor7
    {
        public void Executar()
        {
            double[] alturaAnimais = new double[4];
            var menorAnimal = double.MaxValue;
            var nomeAnimais = "";
            var nomeMenorAnimal = "";

            for (var i = 0; i < alturaAnimais.Length; i++)
            {
                Console.WriteLine("Digite o nome do animal: ");
                nomeAnimais = Console.ReadLine();
                Console.WriteLine("Digite a altura dos animais");
                alturaAnimais[i] = Convert.ToDouble(Console.ReadLine());

                if(alturaAnimais[i] < menorAnimal)
                {
                    menorAnimal = alturaAnimais[i];
                    nomeMenorAnimal = nomeAnimais;
                }
            }
            Console.WriteLine("O menor animal é: " + nomeMenorAnimal + ", sua altura é: " + menorAnimal);
        }
    }
}
