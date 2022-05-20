using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioForTryCatch
{
    internal class Exercicio03
    {
        public void Executar()
        {
            Console.Clear();
            var validar = false;

            while (validar == false)
            {
                try
                {
                    Console.Write("Infome um númer: ");
                    var numero = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i <=1000; i++)
                    {
                        Console.WriteLine(numero + " x "+ i + " = " + (numero * i));
                    }
                    validar = true;
                }
                catch (Exception ex )
                {
                    Console.Write("Número invalido");
                }
            }
            Console.ReadKey();
        }
    }
}
