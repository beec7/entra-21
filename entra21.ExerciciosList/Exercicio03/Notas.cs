using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entra21.ExerciciosList.Exercicio03
{
    internal class Notas
    {
        public void Executar()
        {
            List<double> nota = new List<double>();
            Console.Write("Informe a nota 1: ");
            nota.Add(Convert.ToDouble(Console.ReadLine()));
            Console.Write("Informe a nota 2: ");
            nota.Add(Convert.ToDouble(Console.ReadLine()));
            Console.Write("Informe a nota 3: ");
            nota.Add(Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("Nota 1: " + nota[0] + "\nNota 2: " + nota[1] + "\nNota 3: " + nota[2]);
            Console.WriteLine("Média: " + ((nota[0] + nota[1] + nota[2]) / nota.Count));
            Console.WriteLine(nota.Count());
        }
    }
}
