using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.AtividadesOrientacaoObjetos.Exercício02
{
    public class Temperatura
    {
        public string TemperaturaOrigem;
        public string TemperaturaDestino;
        public double ValorTemperatura;
        public double CalcularCelsius()
        {


            var temperaturaFahrenheit = ValorTemperatura;

                var temperaturaKelvin = ValorTemperatura;

            if (TemperaturaOrigem.StartsWith("k"))

            { 
                temperaturaKelvin = (ValorTemperatura - 273.15);
                return temperaturaKelvin;
            }

            else if (TemperaturaOrigem.StartsWith("f"))
            {

                temperaturaFahrenheit = ((ValorTemperatura- 32) / 1.8);
                return temperaturaFahrenheit;
            }

            return ValorTemperatura;

        }

        public double CalularParaKelvin()
        {

            var temperaturaCelsius = ValorTemperatura;
            var temperaturaFahrenheit = ValorTemperatura;

            if (TemperaturaOrigem.StartsWith("c"))
            {
                temperaturaCelsius = (ValorTemperatura + 273.15);
                return temperaturaCelsius; 
            }
            else if (TemperaturaOrigem.StartsWith("f"))
            {
                temperaturaFahrenheit = ((ValorTemperatura + 32) *1.8 + 273.15);
                return temperaturaFahrenheit;
            }
            return ValorTemperatura;
        }

        public double CalcularFahrenheit()
        {
            var temperaturaCelsius = ValorTemperatura;
            var temperaturaKelvin = ValorTemperatura;

            if (TemperaturaOrigem.StartsWith("k"))
            {
                temperaturaKelvin = ((ValorTemperatura - 32) * 1.8 - 273.15);
                return temperaturaKelvin;
            }
            else if (TemperaturaOrigem.StartsWith("c"))
            {
                temperaturaCelsius = ((ValorTemperatura + 32) / 1.8);
                return temperaturaCelsius;
            }
            return ValorTemperatura;
        }


    }
}
