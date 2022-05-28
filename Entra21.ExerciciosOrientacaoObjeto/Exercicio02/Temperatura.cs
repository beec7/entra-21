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
            return (TemperaturaValor * 1.8) + 32;
        }
        public double CalcularKelvinCelsius()
        {
            return TemperaturaValor - 273.15;
        }
        public double CalcularKelvinFahrenheit()
        {
            return (((CalcularKelvinCelsius()) * 1.8) + 32);
        }
        public double CalcularFahrenheitCelsius()
        {
            return (TemperaturaValor - 32) * 0.55555555555555555555555555555556;
        }
        public double CalcularFahrenheitKelvin()
        {
            return ((CalcularFahrenheitCelsius()) + 273.15);
        }
        public double ApresentarTemperaturaConvertida()
        {
            if (TemperaturaOrigem.ToLower().Trim() == "c" || TemperaturaOrigem.ToLower().Trim() == "celsius")
            {
                if (TemperaturaDestino.ToLower().Trim() == "f" || TemperaturaDestino.ToLower().Trim() == "fahrenheit")
                {
                    return CalcularCelsiusFahrenheit();
                }
                else if (TemperaturaDestino.ToLower().Trim() == "k" || TemperaturaDestino.ToLower().Trim() == "kelvin")
                {
                    return CalcularCelsiusKelvin();
                }
            }
            else if (TemperaturaOrigem.ToLower().Trim() == "k" || TemperaturaOrigem.ToLower().Trim() == "kelvin")
            {
                if (TemperaturaDestino.ToLower().Trim() == "f" || TemperaturaDestino.ToLower().Trim() == "fahrenheit")
                {
                    return CalcularKelvinFahrenheit();
                }
                else if (TemperaturaDestino.ToLower().Trim() == "c" || TemperaturaDestino.ToLower().Trim() == "celsius")
                {
                    return CalcularKelvinCelsius();
                }
            }
            else if (TemperaturaOrigem.ToLower().Trim() == "f" || TemperaturaOrigem.ToLower().Trim() == "fahrenheit")
            {
                if (TemperaturaDestino.ToLower().Trim() == "c" || TemperaturaDestino.ToLower().Trim() == "celsius")
                {
                    return CalcularFahrenheitCelsius();
                }
                else if (TemperaturaDestino.ToLower().Trim() == "k" || TemperaturaDestino.ToLower().Trim() == "kelvin")
                {
                    return CalcularFahrenheitKelvin();
                }
            }
            return 0.0; 
        }

    }
}
