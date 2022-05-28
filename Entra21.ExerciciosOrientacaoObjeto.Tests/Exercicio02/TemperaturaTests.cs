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
    }
}
