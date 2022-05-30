﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.AtividadesOrientacaoObjetos.Exercício02
{
    public class Temperatura
    {
        public double TemperaturaOrigem;
        public double TemperaturaDestino;
        public double ValorTemperatura;
        public double TemperaturaConvertida;


        public double CalcularCelsiusParaKelvin()
        {

            var celsiusParaKelvin = (ValorTemperatura + 273.15);
            return celsiusParaKelvin;

        }

        public double CalcularCelsiusParaFahrenheit()
        {
            var celsiusParaFahrenheit = ((ValorTemperatura * 1.8) + 32);
            return celsiusParaFahrenheit;
        }

        public double CalcularKelvinParaCelsius()
        {
            var kelvinParaCelsius = (ValorTemperatura - 273.15);
            return kelvinParaCelsius;
        }

        public double CalcularKelvinParaFahrenheit()
        {
            var kelvinParaFahrenheit = ((ValorTemperatura * 1.8) - 459.67);
            return kelvinParaFahrenheit;
        }

        public double CalcularFahrenheitParaCelsius()
        {
            var fahrenheitParaCelsius = ((ValorTemperatura - 32) / 1.8);
            return fahrenheitParaCelsius;
        }

        public double CalcularFahrenheitParaKelvin()
        {
            var fahrenheitParaKelvin = ((ValorTemperatura + 459.67) / 1.8);
            return fahrenheitParaKelvin;
        }

        public void ApresentarTemperaturaConvertida()
        {
            
            if (TemperaturaOrigem == 1 && TemperaturaDestino == 2)
            {
                Console.WriteLine("Temperatura origem digitada: Celsius" +
                                    "\nTemperatura destino digitada: Fahrenheit" +
                                    "\nTemperatura convertida: " + CalcularCelsiusParaFahrenheit());
            }
            else if (TemperaturaOrigem == 1 && TemperaturaDestino == 3)
            {
                Console.WriteLine("Temperatura origem digitada: Celsius" +
                                "\nTemperatura destino digitada: Kelvin" +
                                "\nTemperatura convertida: " + CalcularCelsiusParaKelvin());
            }
            else if (TemperaturaOrigem == 2 && TemperaturaDestino == 1)
            {
                Console.WriteLine("Temperatura origem digitada: Fahrenheit" +
                                "\nTemperatura destino digitada: Celsius" +
                                "\nTemperatura convertida: " + CalcularFahrenheitParaCelsius());
            }
            else if (TemperaturaOrigem == 2 && TemperaturaDestino == 3)
            {
                Console.WriteLine("Temperatura origem digitada: Fahrenheit" +
                                "\nTemperatura destino digitada: Kelvin" +
                                "\nTemperatura convertida: " + CalcularFahrenheitParaKelvin());
            }
            else if (TemperaturaOrigem == 3 && TemperaturaDestino == 1)
            {
                Console.WriteLine("Temperatura origem digitada: Kelvin" +
                                "\nTemperatura destino digitada: Celsius" +
                                "\nTemperatura convertida: " + CalcularKelvinParaCelsius());
            }
            else if (TemperaturaOrigem == 3 && TemperaturaDestino == 2)
            {
                Console.WriteLine("Temperatura origem digitada: Kelvin" +
                                "\nTemperatura destino digitada: Fahrenheit" +
                                "\nTemperatura convertida: " + CalcularKelvinParaFahrenheit());
            }
        }
    }
}