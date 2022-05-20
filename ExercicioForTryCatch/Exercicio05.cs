using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioForTryCatch
{
    internal class Exercicio05
    {
        public void Executar()
        {
            string cardapio = @"
Código  Tipo         Nome                                         Valor   
1       Bolos        Bolo Brigadeiro                              R$ 29,50
2       Bolos        Bolo Floresta Negra                          R$ 2,00 
3       Bolos        Bolo Leite com Nutella                       R$ 29,23
4       Bolos        Bolo Mousse de Chocolate                     R$ 7,10 
5       Bolos        Bolo Nega Maluca                             R$ 19,33
6       Doces        Bomba de Creme                               R$ 17,71
7       Doces        Bomba de Morango                             R$ 4,82 
8       Sanduíches   Filé-Mignon com fritas e cheddar             R$ 21,16
9       Sanduíches   Hambúrguer com queijos, champignon e rúcula  R$ 12,70
10      Sanduíches   Provolone com salame                         R$ 19,70
11      Sanduíches   Vegetariano de berinjela                     R$ 28,22
12      Pizzas       Calabresa                                    R$ 8,98 
13      Pizzas       Napolitana                                   R$ 0,42 
14      Pizzas       Peruana                                      R$ 18,36
15      Pizzas       Portuguesa                                   R$ 27,50
16                   Sair                                                 ";

            var loop = true;
            var quantidade = 0;
            var total = 0.0;
            var produtoEscolhido = "";
            var quantidadeBolos = 0;
            var quantidadeDoces = 0;
            var quantidadeSanduíches = 0;
            var quantidadePizzas = 0;
            while (loop == true)
            {
                var validar = false;
                var opcaoDesejada = 0;


                while (validar == false)
                {
                    try
                    {
                        Console.Clear();
                        Console.Write(cardapio + "\nInforme o código do produto:");
                        opcaoDesejada = Convert.ToInt32(Console.ReadLine());
                        if (opcaoDesejada <= 0 || opcaoDesejada > 16)
                        {
                            Console.WriteLine("Não coresponde a um código existente");
                            Console.ReadKey();
                        }
                        else
                        {
                            validar = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.Write("Erro não é um código, Informe um código do menu.");
                        Console.ReadKey();
                    }

                    if (opcaoDesejada == 1)
                    {
                        produtoEscolhido = produtoEscolhido + "Bolos        Bolo Brigadeiro                              R$ 29,50\n";
                        total = total + 29.50;
                        quantidade++;
                        quantidadeBolos++;

                    }
                    else if (opcaoDesejada == 2)
                    {
                        produtoEscolhido = produtoEscolhido + "Bolos        Bolo Floresta Negra                          R$ 2,00 \n";
                        total = total + 2.00;
                        quantidade++;
                        quantidadeBolos++;
                    }
                    else if (opcaoDesejada == 3)
                    {
                        produtoEscolhido = produtoEscolhido + "Bolos        Bolo Leite com Nutella                       R$ 29,23\n";
                        total = total + 29.23;
                        quantidade++;
                        quantidadeBolos++;
                    }
                    else if (opcaoDesejada == 4)
                    {
                        produtoEscolhido = produtoEscolhido + "Bolos        Bolo Mousse de Chocolate                     R$ 7,10 \n";
                        total = total + 7.10;
                        quantidade++;
                        quantidadeBolos++;
                    }
                    else if (opcaoDesejada == 5)
                    {
                        produtoEscolhido = produtoEscolhido + "Bolos        Bolo Nega Maluca                             R$ 19,33\n";
                        total = total + 19.33;
                        quantidade++;
                        quantidadeBolos++;
                    }
                    else if (opcaoDesejada == 6)
                    {
                        produtoEscolhido = produtoEscolhido + "Doces        Bomba de Creme                               R$ 17,71\n";
                        total = total + 17.71;
                        quantidade++;
                        quantidadeDoces++;
                    }
                    else if (opcaoDesejada == 7)
                    {
                        produtoEscolhido = produtoEscolhido + "Doces        Bomba de Morango                             R$ 4,82 \n";
                        total = total + 4.82;
                        quantidade++;
                        quantidadeDoces++;
                    }
                    else if (opcaoDesejada == 8)
                    {
                        produtoEscolhido = produtoEscolhido + "Sanduíches   Filé-Mignon com fritas e cheddar             R$ 21,16\n";
                        total = total + 21.16;
                        quantidade++;
                        quantidadeSanduíches++;
                    }
                    else if (opcaoDesejada == 9)
                    {
                        produtoEscolhido = produtoEscolhido + "Sanduíches   Hambúrguer com queijos, champignon e rúcula  R$ 12,70\n";
                        total = total + 12.70;
                        quantidade++;
                        quantidadeSanduíches++;
                    }
                    else if (opcaoDesejada == 10)
                    {
                        produtoEscolhido = produtoEscolhido + "Sanduíches   Provolone com salame                         R$ 19,70\n";
                        total = total + 19.70;
                        quantidade++;
                        quantidadeSanduíches++;

                    }
                    else if (opcaoDesejada == 11)
                    {
                        produtoEscolhido = produtoEscolhido + "Sanduíches   Vegetariano de berinjela                     R$ 28,22\n";
                        total = total + 28.22;
                        quantidade++;
                        quantidadeSanduíches++;
                    }
                    else if (opcaoDesejada == 12)
                    {
                        produtoEscolhido = produtoEscolhido + "Pizzas       Calabresa                                    R$ 8,98 \n";
                        total = total + 8.98;
                        quantidade++;
                        quantidadePizzas++;
                    }
                    else if (opcaoDesejada == 13)
                    {
                        produtoEscolhido = produtoEscolhido + "Pizzas       Napolitana                                   R$ 0,42 \n";
                        total = total + 0.42;
                        quantidade++;
                        quantidadePizzas++;

                    }
                    else if (opcaoDesejada == 14)
                    {
                        produtoEscolhido = produtoEscolhido + "Pizzas       Peruana                                      R$ 18,36\n";
                        total = total + 18.36;
                        quantidade++;
                        quantidadePizzas++;
                    }
                    else if (opcaoDesejada == 15)
                    {
                        produtoEscolhido = produtoEscolhido + "Pizzas       Portuguesa                                   R$ 27,50\n";
                        total = total + 27.50;
                        quantidade++;
                        quantidadePizzas++;
                    }
                    else if (opcaoDesejada == 16)
                    {
                        loop = false;
                    }
                }
            }
            Console.Clear();
            Console.WriteLine(@"
Produtos\n" +
produtoEscolhido + "" +
"\nTotal:" + total +
"\nBolos: " + quantidadeBolos +
"\nDoces: " + quantidadeDoces +
"\nSanduíches: " + quantidadeSanduíches +
"\nPizzas: " + quantidadePizzas);
            Console.ReadLine();
        }
    }
}
