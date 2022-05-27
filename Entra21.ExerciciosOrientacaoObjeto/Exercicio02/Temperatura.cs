using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjeto.Exercicio02
{
    public class Temperatura
    {
        //Criar uma classe chamada Temperatura, armazenar as seguintes propriedades:
        //● temperatura de origem
        //● Temperatura de destino
        //● Temperatura
        public string TemperaturaOrigem;
        public string TemperaturaDestino;
        public double TemperaturaValor;

      public double CalcularCelsiusKelvin()
        {
            return (TemperaturaValor + 273.15);
        }
        public double CalcularCelsiusFahrenheit()
        {
            return (TemperaturaValor * (9 / 5)) + 32;
        }
        public double CalcularKelvinCelsius()
        {
            return TemperaturaValor - 273.15;
        }
        public double CalcularKelvinFahrenheit()
        {
            return (CalcularKelvinCelsius() * (9 / 5)) + 32;
        }
        public double CalcularFahrenheitCelsius()
        {
            return (TemperaturaValor - 32) * (5/9); 
        }
        public double CalcularFahrenheitKelvin()
        {
            return (CalcularFahrenheitCelsius() + 273.15);
        }
        public void ApresentarTemperaturaConvertida()
        {

        }

    }
}
