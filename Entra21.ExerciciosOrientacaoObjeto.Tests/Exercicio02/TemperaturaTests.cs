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

        [Theory]
        [InlineData(10, -441.66999999999996)]
        [InlineData(0, -459.66999999999996)]
        public void Validar_CalcularKelvinFahrenheit(double temperaturaEntrada, double temperaturaConvertida)
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.TemperaturaValor = temperaturaEntrada;

            // Act
            var temperaturaFinal = temperatura.CalcularKelvinFahrenheit();

            // Assert
            temperaturaFinal.Should().Be(temperaturaConvertida);

        }

        [Theory]
        [InlineData(10, -12.222222222222223)]
        [InlineData(0, -17.77777777777778)]
        public void Validar_CalcularFahrenheitCelsius(double temperaturaEntrada, double temperaturaConvertida)
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.TemperaturaValor = temperaturaEntrada;

            // Act
            var temperaturaFinal = temperatura.CalcularFahrenheitCelsius();

            // Assert
            temperaturaFinal.Should().Be(temperaturaConvertida);
        }

        [Theory]
        [InlineData(10, 260.92777777777775)]
        [InlineData(0, 255.3722222222222)]
        public void Validar_CalcularFahrenheitKelvin(double temperaturaEntrada, double temperaturaConvertida)
        {
            // Arrange
            var temperatura = new Temperatura();
            temperatura.TemperaturaValor = temperaturaEntrada;

            // Act
            var temperaturaFinal = temperatura.CalcularFahrenheitKelvin();

            // Assert
            temperaturaFinal.Should().Be(temperaturaConvertida);
        }
        


    }
}
