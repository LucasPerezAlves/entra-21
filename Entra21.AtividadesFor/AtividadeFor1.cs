using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.AtividadesFor
{
    internal class AtividadeFor1
    {
        public void Executar()
        {
            for (var i = 0; i < 13; i = i + 1)
            {

                var valorValido = true;
                while (valorValido == true)
                {
                    try
                    {
                        Console.WriteLine("Digite o nome da peça: ");
                        int nome = Convert.ToInt32(Console.ReadLine());
                        valorValido = false;

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Erro na digitação");


                    }
                }
            }
        }
    }
}
