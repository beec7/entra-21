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
                return (TemperaturaDestino.ToLower().Trim() == "f" || TemperaturaDestino.ToLower().Trim() == "fahrenheit")
                  ? CalcularCelsiusFahrenheit()
                  : CalcularCelsiusKelvin();
            }

            if (TemperaturaOrigem.ToLower().Trim() == "k" || TemperaturaOrigem.ToLower().Trim() == "kelvin")
            {
                return (TemperaturaDestino.ToLower().Trim() == "f" || TemperaturaDestino.ToLower().Trim() == "fahrenheit")
                    ? CalcularKelvinFahrenheit()
                    : CalcularKelvinCelsius();
            }

            if (TemperaturaOrigem.ToLower().Trim() == "f" || TemperaturaOrigem.ToLower().Trim() == "fahrenheit")
            {
                return (TemperaturaDestino.ToLower().Trim() == "c" || TemperaturaDestino.ToLower().Trim() == "celsius")
                    ? CalcularFahrenheitCelsius()
                    : CalcularFahrenheitKelvin();
            }
            return 0.0;
        }
        public void ValidarEntrada()
        {
            var validar = false;
            while (validar == false)
            {
                try
                {
                    Console.Write("Temperatura Atual (C,K,f): ");
                    TemperaturaOrigem = Console.ReadLine().ToLower().Trim();
                    if (TemperaturaOrigem == "c" || TemperaturaOrigem == "celsius" || TemperaturaOrigem == "k" || TemperaturaOrigem == "kelvin" || TemperaturaOrigem == "f" || TemperaturaOrigem == "fahrenheit")
                    {
                        validar = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                }
            }

            validar = false;
            while (validar == false)
            {
                try
                {
                    Console.Write("Temperatura destino (c,k,f): ");
                    TemperaturaDestino = Console.ReadLine();
                    if (TemperaturaDestino == "c" || TemperaturaDestino == "celsius" || TemperaturaDestino == "k" || TemperaturaDestino == "kelvin" || TemperaturaDestino == "f" || TemperaturaDestino == "fahrenheit" && TemperaturaDestino != TemperaturaOrigem)
                    {
                        validar = true;

                    }
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                }
            }

            validar = false;
            while (validar == false)
            {
                try
                {
                    Console.Write("Valor da Temperatura: ");
                    TemperaturaValor = Convert.ToDouble(Console.ReadLine());
                    validar = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
    }
}
