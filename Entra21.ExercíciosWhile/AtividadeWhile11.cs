using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExercíciosWhile
{
    internal class AtividadeWhile11
    {
        public void Executar()
        {

      
            
            int menu = 0;
           

            while(menu != 5)
            {
                

                Console.WriteLine("Digite um número: ");
                double numero = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o segundo número: ");
                double numero2 = Convert.ToDouble(Console.ReadLine());


                double soma = numero + numero2;
                double subtracao = numero - numero2;
                double multiplicacao = numero * numero2;
                double divisao = numero / numero2;

                Console.WriteLine(@"Escolha a operação aritmética:

  Menu
1 - soma
2 - subtração
3 - multiplicação
4 - divisão
5 - sair");
               menu = Convert.ToInt32(Console.ReadLine());
                

                if (menu == 1)
                {
                    Console.Write("A sua soma é: " + soma + " ");
                }
                else if (menu == 2)
                {
                    Console.Write("A sua subtração é: " + subtracao + " ");
                }
                else if (menu == 3)
                {
                    Console.Write("A sua multiplicação é: " + multiplicacao + " ");
                }
                else if (menu == 4)
                {
                    Console.Write("A sua divisão é: " + divisao + " ");
                }
               
            }
        }

    }
}
