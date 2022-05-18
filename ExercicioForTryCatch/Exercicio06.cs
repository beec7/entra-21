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
            /*
            Lembrando que um time de futebol terá 22 jogadores.
            Ao final deve-se apresentar as seguintes estatísticas:

            ➔ O jogador com o menor peso;
            ➔ O jogador com a maior altura;
            ➔ O jogador com o maior nome;
            ➔ A quantidade de jogadores do sexo F
            ➔ A quantidade de jogadores do sexo M
            ➔ O jogador com a menor quantidade de cartões amarelos recebidos;
            ➔ O jogador com o menor nome;
            ➔ O jogador com o maior peso;
            ➔ O jogador com a maior quantidade de cartões vermelhos recebidos;
            ➔ O jogador com a maior quantidade de cartões amarelos recebidos;
            ➔ O jogador com a menor quantidade de cartões vermelhos recebidos.*/
            var quantidadeJogador = 3;
            var sexoMasculino = 0;
            var sexoFaminino = 0;

            for (int i = 0; i < quantidadeJogador; i++)
            {
                var nome = "";
                var idade = 0;
                var peso = 0.0;
                var sexo = "";
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
                        nome = Console.ReadLine();
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
                    catch
                    {
                        Console.Write("Erro.!?!");
                    }
                }
                validar = false;
                while (validar == false)
                {
                    try
                    {
                        Console.Clear();
                        Console.Write("Idade: ");
                        idade = Convert.ToInt32(Console.ReadLine());
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
                        Console.Write("Erro.!?!");
                    }
                }
                validar = false;
                while (validar == false)
                {
                    try
                    {
                        Console.Clear();
                        Console.Write("Peso: ");
                        peso = Convert.ToDouble(Console.ReadLine());
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
                    catch
                    {
                        Console.Write("Erro.!?!");
                    }
                }
                validar = false;
                while (validar == false)
                {
                    try
                    {
                        Console.Clear();
                        Console.Write("Sexo: ");
                        sexo = Console.ReadLine();
                        if (sexo.ToLower().Trim() == "m" || sexo.ToLower().Trim() == "homem" || sexo.ToLower().Trim() == "masculino")
                        {
                            sexoMasculino++;
                            validar = true;
                        }
                        else
                        if (sexo.ToLower().Trim() == "f" || sexo.ToLower().Trim() == "mulher" || sexo.ToLower().Trim() == "feminino")
                        {
                            sexoFaminino++;
                            validar = true;
                        }
                        else
                        {
                            Console.WriteLine("Sexo invalido Informe novamente.");
                            Console.ReadKey();
                        }
                    }
                    catch
                    {
                        Console.Write("Erro.!?!");
                    }
                }

            }

        }
    }
}
}
