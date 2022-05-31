using Entra21.AtividadesOrientacaoObjetos.Exercício02;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Entra21.AtividadesOrinentacaoObjeto.Tests.Exercicio2.test
{
    public class TemperaturaTest
    {
        [Fact]

        public void Validar_Celsius_Para_Fahrenheit()
        {

            //Arrange
            var temperatura = new Temperatura();
            temperatura.TemperaturaOrigem = 1;
            temperatura.TemperaturaDestino = 2;
            temperatura.ValorTemperatura = 50;
            //Act
            var graus = temperatura.CalcularCelsiusParaFahrenheit();
            //Assert
            graus.Should().Be(122);
        }

        [Fact]
        public void Validar_Celsius_Para_Kelvin()
        {
            //Arrange
            var temperatura = new Temperatura();
            temperatura.TemperaturaOrigem = 1;
            temperatura.TemperaturaDestino = 3;
            temperatura.ValorTemperatura = 70;
            //Act
            var graus = temperatura.CalcularCelsiusParaKelvin;
            //Assert
            graus.Should().Be(122);
        }

    }
}
