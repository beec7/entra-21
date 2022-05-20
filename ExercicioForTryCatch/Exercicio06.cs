using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioForTryCatch
{
    internal class Exercicio06
    {
        public void Executar()
        {

            var quantidadeJogador = 2;

            var sexoMasculino = 0;
            var sexoFeminino = 0;
            var maiorPeso = double.MinValue;
            var nomeMaiorPeso = "";
            var menorPeso = double.MaxValue;
            var nomeMenorPeso = "";
            var maiorNome = "";
            var menorNome = "";
            var maiorAltura = double.MinValue;
            var nomeMaiorAltura = "";
            var nomeMaiorQuantidadeCartoesVermelho = "";
            var nomeMenorQuantidadeCartoesVermelho = "";
            var nomeMaiorQuantidadeCartoesAmarelo = "";
            var nomeMenorQuantidadeCartoesAmarelo = "";

            var tamanhoMaiorNome = int.MinValue;
            var tamanhoMenorNome = int.MaxValue;
            var maiorQuantidadeCartoesAmarelo = int.MinValue;
            var menorQuantidadeCartoesAmarelo = int.MaxValue;
            var maiorQuantidadeCartoesVermelho = int.MinValue;
            var menorQuantidadeCartoesVermelho = int.MaxValue;

            for (int i = 0; i < quantidadeJogador; i++)
            {
                var nome = "";
                var idade = 0;
                var peso = 0.0;
                var altura = 0.0;
                var quantidadeGol = 0;
                var quantidadeCartoesAmarelo = 0;
                var quantidadeCartoesVermelho = 0;
                var validar = false;

                while (validar == false)
                {
                    try
                    {
                        Console.Clear();
                        Console.Write("Nome: ");
                        nome = Console.ReadLine().Trim();
                        if (nome.Length < 2)
                        {
                            Console.Write("Informe o nome. não o apelido.");
                            Console.ReadKey();
                        }
                        else
                        {
                            validar = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.Write("Erro.!?!");
                        Console.ReadKey();
                    }
                }

                validar = false;
                while (validar == false)
                {
                    try
                    {
                        Console.Clear();
                        Console.Write("Idade: ");
                        idade = Convert.ToInt32(Console.ReadLine().Trim());
                        if (idade <= 0)
                        {
                            Console.Write("Idade não pode ser menor do que 0.");
                            Console.ReadKey();
                        }
                        else if (idade > 100)
                        {
                            Console.Write("Verifique se ainda esta vivo");
                            Console.ReadKey();
                        }
                        else
                        {
                            validar = true;
                        }
                    }
                    catch
                    {
                        Console.Write("Erro.Tem que ser número Inteiro.");
                        Console.ReadKey();
                    }
                }

                validar = false;
                while (validar == false)
                {
                    try
                    {
                        Console.Clear();
                        Console.Write("Peso: ");
                        peso = Convert.ToDouble(Console.ReadLine().Trim());
                        if (peso <= 0)
                        {
                            Console.Write("Idade não pode ser menor do que 0.");
                            Console.ReadKey();
                        }
                        else
                        {
                            validar = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.Write("Erro. Informe um número. \nEx 70.10");
                        Console.ReadKey();
                    }
                }

                validar = false;
                while (validar == false)
                {
                    try
                    {
                        Console.Clear();
                        Console.Write("Altura: ");
                        altura = Convert.ToDouble(Console.ReadLine().Trim());
                        if (altura <= 0)
                        {
                            Console.Write("Até uma formiga é maior do que isso.");
                            Console.ReadKey();
                        }
                        else
                        {
                            validar = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.Write("Erro. Informe um número. \nEx 1.70");
                        Console.ReadKey();
                    }
                }

                validar = false;
                while (validar == false)
                {
                    try
                    {
                        Console.Clear();
                        Console.Write("Sexo: ");
                        var sexo = Console.ReadLine().Trim();
                        if (sexo.ToLower().Trim() == "m" || sexo.ToLower().Trim() == "homem" || sexo.ToLower().Trim() == "masculino")
                        {
                            sexoMasculino++;
                            validar = true;
                        }
                        else
                        if (sexo.ToLower().Trim() == "f" || sexo.ToLower().Trim() == "mulher" || sexo.ToLower().Trim() == "feminino")
                        {
                            sexoFeminino++;
                            validar = true;
                        }
                        else
                        {
                            Console.WriteLine("Sexo invalido Informe novamente.");
                            Console.ReadKey();
                        }
                    }
                    catch (Exception ex)
                    { 
                        Console.Write("Erro.Informe novamente.");
                        Console.ReadKey();
                    }
                }

                validar = false;
                while (validar == false)
                {
                    try
                    {
                        Console.Clear();
                        Console.Write("Quantos de gol: ");
                        quantidadeGol = Convert.ToInt32(Console.ReadLine().Trim());
                        if (quantidadeGol > 0)
                        {
                            validar = true;
                        }
                        else
                        {
                            Console.WriteLine("Quantidade de gol não pode ser negativa");
                            Console.ReadKey();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.Write("Erro.tem que ser número inteiro");
                        Console.ReadKey();
                    }
                }

                validar = false;
                while (validar == false)
                {
                    try
                    {
                        Console.Clear();
                        Console.Write("Quantos de Cartões Amarelo: ");
                        quantidadeCartoesAmarelo = Convert.ToInt32(Console.ReadLine().Trim());
                        if (quantidadeCartoesAmarelo >= 0)
                        {
                            validar = true;
                        }
                        else
                        {
                            Console.WriteLine("Não existe cartões bonos.");
                            Console.ReadKey();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.Write("Erro.tem que ser número inteiro");
                        Console.ReadKey();
                    }
                }

                validar = false;
                while (validar == false)
                {
                    try
                    {
                        Console.Clear();
                        Console.Write("Quantos de Cartões Vermelho: ");
                        quantidadeCartoesVermelho = Convert.ToInt32(Console.ReadLine().Trim());
                        if (quantidadeCartoesVermelho >= 0)
                        {
                            validar = true;
                        }
                        else
                        {
                            Console.WriteLine("Não existe cartões bonos.");
                            Console.ReadKey();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.Write("Erro.tem que ser número inteiro");
                        Console.ReadKey();
                    }
                }
                /*
            Lembrando que um time de futebol terá 22 jogadores.
            Ao final deve-se apresentar as seguintes estatísticas:

            ➔ A quantidade de jogadores do sexo F x
            ➔ A quantidade de jogadores do sexo M x*/

                //➔ O jogador com o maior peso;
                //➔ O jogador com o menor peso;
                if (peso > maiorPeso)
                {
                    maiorPeso = peso;
                    nomeMaiorPeso = nome;
                }
                else if (peso == maiorPeso)
                {
                    nomeMaiorPeso += " " + nome;
                }

                if (peso < menorPeso)
                {
                    menorPeso = peso;
                    nomeMenorPeso = nome;
                }
                else if (peso == menorPeso)
                {
                    nomeMenorPeso += "\n" + nome;
                }


                //➔ O jogador com a maior altura;
                if (altura > maiorAltura)
                {
                    maiorAltura = altura;
                    nomeMaiorAltura = nome;
                }
                else if (altura == maiorAltura)
                {
                    nomeMaiorAltura += "\n" + nome;
                }

                //➔ O jogador com o maior nome;
                //➔ O jogador com o menor nome;

                if (nome.Trim().Length > tamanhoMaiorNome)
                {
                    tamanhoMaiorNome = nome.Trim().Length;
                    maiorNome = nome;
                }
                else if (nome.Trim().Length == tamanhoMaiorNome)
                {
                    maiorNome += "\n" + nome;
                }

                if (nome.Trim().Length < tamanhoMenorNome)
                {
                    tamanhoMenorNome = nome.Trim().Length;
                    menorNome = nome;
                }
                else if (nome.Trim().Length == tamanhoMenorNome)
                {
                    menorNome += "\n" + nome;
                }

                //➔ O jogador com a menor quantidade de cartões amarelos recebidos;
                //➔ O jogador com a maior quantidade de cartões amarelos recebidos;

                if (quantidadeCartoesAmarelo > maiorQuantidadeCartoesAmarelo)
                {
                    maiorQuantidadeCartoesAmarelo = quantidadeCartoesAmarelo;
                    nomeMaiorQuantidadeCartoesAmarelo = nome;
                }
                else if (quantidadeCartoesAmarelo == maiorQuantidadeCartoesAmarelo)
                {
                    nomeMaiorQuantidadeCartoesAmarelo += "\n" + nome;
                }

                if (quantidadeCartoesAmarelo < menorQuantidadeCartoesAmarelo)
                {
                    menorQuantidadeCartoesAmarelo = quantidadeCartoesAmarelo;
                    nomeMenorQuantidadeCartoesAmarelo = nome;
                }
                else if (quantidadeCartoesAmarelo == menorQuantidadeCartoesAmarelo)
                {
                    nomeMenorQuantidadeCartoesAmarelo += "\n" + nome;
                }

                //➔ O jogador com a maior quantidade de cartões vermelhos recebidos;
                //➔ O jogadorn com a menor quantidade de cartões vermelhos recebidos

                if (quantidadeCartoesVermelho > maiorQuantidadeCartoesVermelho)
                {
                    maiorQuantidadeCartoesVermelho = quantidadeCartoesVermelho;
                    nomeMaiorQuantidadeCartoesVermelho = nome;
                }
                else if (quantidadeCartoesVermelho == maiorQuantidadeCartoesVermelho)
                {
                    nomeMaiorQuantidadeCartoesVermelho += "\n" + nome;
                }

                if (quantidadeCartoesVermelho < menorQuantidadeCartoesVermelho)
                {
                    menorQuantidadeCartoesVermelho = quantidadeCartoesVermelho;
                    nomeMenorQuantidadeCartoesVermelho = nome;
                }
                else if (quantidadeCartoesAmarelo == menorQuantidadeCartoesVermelho)
                {
                    nomeMenorQuantidadeCartoesVermelho += "\n" + nome;
                }
            }
            Console.Write("Nome e peso do maior peso:\n" + nomeMaiorPeso + "\n" + maiorPeso + "\n\n" +
                "Nome e peso menor peso:\n" + nomeMenorPeso + "\n" + menorPeso + "\n\n" +
                "Nome e altura do maior altura:\n" + nomeMaiorAltura + "\n" + maiorAltura + "\n\n" +
                "Total de cada sexo:\n" + "MASCULINO: " + sexoMasculino + "\nFEMININO: " + sexoFeminino + "\n\n" +
                "Jogador com maior nome:\n" + maiorNome + "\n" + tamanhoMaiorNome + "\n" +
                "Jogador com menor nome:\n" + menorNome + "\n" + tamanhoMenorNome + "\n\n" +
                "Jogador com a maior quantidade de cartoes amarelo recebido:\n" + nomeMaiorQuantidadeCartoesAmarelo + "\n" + maiorQuantidadeCartoesAmarelo + "\n" +
                "Jogador com a menor quantidade de cartoes amarelo recebido:\n" + nomeMenorQuantidadeCartoesAmarelo + "\n" + menorQuantidadeCartoesAmarelo + "\n\n" +
                "Jogador com a maior quantidade de cartoes vermelho recebido:\n" + nomeMaiorQuantidadeCartoesVermelho + "\n" + maiorQuantidadeCartoesVermelho + "\n" +
                "Jogador com a menor quantidade de cartoes vermelho recebido:\n" + nomeMenorQuantidadeCartoesVermelho + "\n" + menorQuantidadeCartoesVermelho + "\n");
                Console.ReadKey();

        }
    }
}

