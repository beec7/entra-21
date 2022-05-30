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
            temperatura.ValidarEntrada();
            Console.WriteLine("A temperatura de " + temperatura.TemperaturaOrigem +" para " + temperatura.TemperaturaDestino +
                " é = " + temperatura.ApresentarTemperaturaConvertida());
        }
    }
}
