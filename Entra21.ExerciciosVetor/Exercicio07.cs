using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio07
    {
        public void Executar()
        {
            var quantidade = 4;
            var animais = new string[quantidade];
            var alturas = new double[quantidade];

            for (var i = 0; i < alturas.Length; i++)
            {
                
                Console.Write($"Nome do {i + 1} Animal:");
                animais[i] = Console.ReadLine();

                while(animais[i].Length < 2)
                {
                    Console.Write("Quantidade de caracter insuficiente.");
                    Console.Write("Informe o nome correto: ");
                    animais[i] = Console.ReadLine();
                }
                var validar = false;
                while (validar == false)
                {
                    try
                    {
                        Console.Write($"Altura do {i + 1} Animal:");
                        alturas[i] = Convert.ToDouble(Console.ReadLine());
                        if(alturas[i] > 0.0)
                        {
                            Console.Write("Altura negativa não é valida");
                        }
                        else
                        {
                            validar = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.Write("Erro. Informe a altura novamente");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
            }
            var maiorAltura = double.MinValue;
            var animalMaiorAltura = 0;
            for (int i = 0; i < quantidade; i++)
            {
                if(maiorAltura < alturas[i])
                {
                    maiorAltura = alturas[i];
                    animalMaiorAltura = i;
                }
            }
            Console.WriteLine($"O {animais[animalMaiorAltura]} é o animais mais alto com {alturas[animalMaiorAltura]}");
            Console.ReadKey();
        }
    }
}
