using Entra21.ExerciciosOrientacaoObjeto.Exercicio02;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Entra21.ExerciciosOrientacaoObjeto.Tests.Exercicio02
{
    public class TemperaturaTests
    {
        [Fact]
        public void Validar_CalcularCelsiusKelvin()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.TemperaturaValor = 10;

            // Act
            var temperaturaFinal = temperatura.CalcularCelsiusKelvin();

            //Assert
            temperaturaFinal.Should().Be(283.15);
        }

        [Fact]
        public void Validar_CalcularCelsiusFahrenheit()
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.TemperaturaValor = 10;

            // Act
            var temperaturaFinal = temperatura.CalcularCelsiusFahrenheit();
            var valorTemperaturaVerificar = (10 * 1.8) + 32;

            // Assert
            temperaturaFinal.Should().Be(valorTemperaturaVerificar);
        }

        [Theory]
        [InlineData(10, -263.15)]
        [InlineData(0, -273.15)]


        public void Validar_CalcularKelvinCelsius(double temperaturaEntrada, double temperaturaConvertida)
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.TemperaturaValor = temperaturaEntrada;

            // Act
            var temperaturaFinal = temperatura.CalcularKelvinCelsius();

            // Assert
            temperaturaFinal.Should().Be(temperaturaConvertida);

        }
    }
}
