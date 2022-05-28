using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjeto.Exercicio02
{
    public class ExemploTemperatura
    {
        public void Executar()
        {
            Temperatura temperatura = new Temperatura();
            Console.Write("Temperatura Atual (C,K,f): ");
            temperatura.TemperaturaOrigem = Console.ReadLine();
            Console.Write("Temperatura destino (c,k,f): ");
            temperatura.TemperaturaDestino = Console.ReadLine();
            Console.Write("Valor da Temperatura: ");
            temperatura.TemperaturaValor = Convert.ToDouble(Console.ReadLine());
            var temperaturaAtual = temperatura.ApresentarTemperaturaConvertida();
            Console.WriteLine("A temperatura de " + temperatura.TemperaturaOrigem +" para " + temperatura.TemperaturaDestino +
                " é = " + temperaturaAtual);
        }
    }
}
