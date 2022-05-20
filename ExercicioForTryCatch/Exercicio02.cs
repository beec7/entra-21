using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioForTryCatch
{
    internal class Exercicio02
    {
        public void Executar()
        {
            var quantidadeCarros = 0;
            var quantidadeCarroLetraG = 0;
            var quantidadeCarroLetraA = 0;
            var somaAno = 0;
            var somaValor = 0.0;
            var validar = false;
            while (validar == false)
            {
                try
                {
                    Console.Clear();
                    Console.Write("Informe a quantidade de carros para cadastrar: ");
                    quantidadeCarros = Convert.ToInt32(Console.ReadLine());

                    if (quantidadeCarros <= 0)
                    {
                        Console.WriteLine("A quantidade de carros tem que ser maior do que 0.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        validar = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Informe um número INTEIR: ");
                }
            }

            for (int i = 0; i < quantidadeCarros; i++)
            {
                var modelo = "";
                var valor = 0.0;
                var ano = 0;
                validar = false;
                while (validar == false)
                {
                    try
                    {
                        Console.Write("Informe o nome(Modelo) do carro: ");
                        modelo = Console.ReadLine();
                        Console.Clear();
                        if (modelo.Length > 1)
                        {
                            validar = true;
                        }
                        else
                        {
                            Console.WriteLine("Informe um nome valido");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("...");
                    }
                }
                validar = false;
                while (validar == false)
                {
                    try
                    {
                        Console.Write("Informe o valor do carro: ");
                        valor = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();

                        if (valor <=0)
                        {
                            Console.WriteLine("O valor do carro não pode ser negativo ou 0.0");

                        }
                        else
                        {
                            validar = true;
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Tem que ser um número");
                    }
                }
                validar = false;
                while (validar == false)
                {
                    try
                    {
                        Console.Write("Informe o ano do carro: ");
                        ano = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        if (ano < 1000)
                        {
                            Console.WriteLine("Não tem carro nesse ano.");

                        }
                        else if (ano >DateTime.Now.Year+1)
                        {
                            Console.Write("Não estamos no futuro:");
                        }
                        else
                        {
                            validar = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Ano invalido");
                    }
                }
                //Processo
                if (modelo.ToLower().Trim().StartsWith("a"))
                {
                    quantidadeCarroLetraA++;
                }
                if (modelo.ToLower().Trim().StartsWith("g"))
                {
                    quantidadeCarroLetraG++;
                }
                somaAno += ano;
                somaValor += valor;
            }
            Console.Clear();
            Console.WriteLine("Média de ano dos carros: " +somaAno/quantidadeCarros +
                "\nMédia de valor dos carros: " + somaValor/quantidadeCarros +
                "\nQuantidade de carros que começão com a letra A: " + quantidadeCarroLetraA +
                "\nQuantidade de carros que começão com a letra G: " + quantidadeCarroLetraG);
            Console.ReadKey();
        }
    }
}
