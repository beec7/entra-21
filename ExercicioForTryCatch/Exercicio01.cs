using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioForTryCatch
{
    internal class Exercicio01
    {
        public void Executar()
        {
            for (int i = 0; i < 13; i++)
            {
                var nomeValdio = false;
                while (nomeValdio == false)
                {
                    try
                    {
                        Console.Write("Nome da peça: ");
                        var nome = Console.ReadLine();
                        if (nome.Length > 3)
                        {
                            nomeValdio = true;
                        }
                        else
                        {
                            Console.Write("Nome deve conter mais do que 3 letras");
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.Write("Caralho vc esta fazendo merda");
                    }

                }
                var valorValido = false;
                while (valorValido == false)
                {
                    try
                    {
                        Console.Write("Valor da peça:");
                        var valor = Convert.ToDouble(Console.ReadLine());
                        if (valor <= 0)
                        {
                            Console.Write("Valor não pode ser negativo");
                        }
                        else if (valor < 100000000.0)
                        {
                            Console.Write("Valor excedeu o limite ");
                        }
                        else
                        {
                            valorValido = true;
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.Write("Valor invalido, Digite novamente");
                    }
                }

            }
        }
    }
}
