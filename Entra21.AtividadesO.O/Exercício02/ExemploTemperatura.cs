using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.AtividadesOrientacaoObjetos.Exercício02
{
    public class ExemploTemperatura
    {
        public void Executar()
        {
            Temperatura temperatura = new Temperatura();


            var table = new ConsoleTable("Código", "Temperaturas");

            Console.Write("Digite a temperatura desejada:");
            temperatura.ValorTemperatura = Convert.ToInt32(Console.ReadLine());
            

            table.Configure(x => x.EnableCount = false);

            table.AddRow("1 -", "Celsius");
            table.AddRow("2 -", "Fahrenheit");
            table.AddRow("3 -", "Kelvin");

            table.Write();

            Console.WriteLine("Digite o numero da temperatura origem: ");
            temperatura.TemperaturaOrigem = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o número da temperatura destino: ");
            temperatura.TemperaturaDestino = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            temperatura.ApresentarTemperaturaConvertida();

           
        }
    }
}
