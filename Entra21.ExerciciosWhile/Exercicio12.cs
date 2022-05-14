using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio12
    {
        public void Executar()
        {
            /**/
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

            bool loop = true;
            int contador = 0;
            int quantidadeBolos = 0, quantidadeDoces = 0, quantidadeSanduíches = 0, quantidadePizzas = 0;
            double total = 0.0;
            string podutoEscolhido = "";

            while (loop == true)
            {
                Console.WriteLine(cardapio);
                Console.Write("Informe o código:");
                int opcaoDesejada = Convert.ToInt32(Console.ReadLine());


                if (opcaoDesejada != 16)
                {
                    if (opcaoDesejada == 1)
                    {
                        podutoEscolhido = podutoEscolhido + "Bolos        Bolo Brigadeiro                              R$ 29,50\n";
                        total = total + 29.50;
                        contador = contador + 1;
                        quantidadeBolos = quantidadeBolos + 1;

                    }
                    else if (opcaoDesejada == 2)
                    {
                        podutoEscolhido = podutoEscolhido + "Bolos        Bolo Floresta Negra                          R$ 2,00 \n";
                        total = total + 2.00;
                        contador = contador + 1;
                        quantidadeBolos = quantidadeBolos + 1;
                    }
                    else if (opcaoDesejada == 3)
                    {
                        podutoEscolhido = podutoEscolhido + "Bolos        Bolo Leite com Nutella                       R$ 29,23\n";
                        total = total + 29.23;
                        contador = contador + 1;
                        quantidadeBolos = quantidadeBolos + 1;
                    }
                    else if (opcaoDesejada == 4)
                    {
                        podutoEscolhido = podutoEscolhido + "Bolos        Bolo Mousse de Chocolate                     R$ 7,10 \n";
                        total = total + 7.10;
                        contador = contador + 1;
                        quantidadeBolos = quantidadeBolos + 1;
                    }
                    else if (opcaoDesejada == 5)
                    {
                        podutoEscolhido = podutoEscolhido + "Bolos        Bolo Nega Maluca                             R$ 19,33\n";
                        total = total + 19.33;
                        contador = contador + 1;
                        quantidadeBolos = quantidadeBolos + 1;
                    }
                    else if (opcaoDesejada == 6)
                    {
                        podutoEscolhido = podutoEscolhido + "Doces        Bomba de Creme                               R$ 17,71\n";
                        total = total + 17.71;
                        contador = contador + 1;
                        quantidadeDoces = quantidadeDoces + 1;
                    }
                    else if (opcaoDesejada == 7)
                    {
                        podutoEscolhido = podutoEscolhido + "Doces        Bomba de Morango                             R$ 4,82 \n";
                        total = total + 4.82;
                        contador = contador + 1;
                        quantidadeDoces = quantidadeDoces + 1;
                    }
                    else if (opcaoDesejada == 8)
                    {
                        podutoEscolhido = podutoEscolhido + "Sanduíches   Filé-Mignon com fritas e cheddar             R$ 21,16\n";
                        total = total + 21.16;
                        contador = contador + 1;
                        quantidadeSanduíches = quantidadeSanduíches + 1;
                    }
                    else if (opcaoDesejada == 9)
                    {
                        podutoEscolhido = podutoEscolhido + "Sanduíches   Hambúrguer com queijos, champignon e rúcula  R$ 12,70\n";
                        total = total + 12.70;
                        contador = contador + 1;
                        quantidadeSanduíches = quantidadeSanduíches + 1;
                    }
                    else if (opcaoDesejada == 10)
                    {
                        podutoEscolhido = podutoEscolhido + "Sanduíches   Provolone com salame                         R$ 19,70\n";
                        total = total + 19.70;
                        contador = contador + 1;
                        quantidadeSanduíches = quantidadeSanduíches + 1;

                    }
                    else if (opcaoDesejada == 11)
                    {
                        podutoEscolhido = podutoEscolhido + "Sanduíches   Vegetariano de berinjela                     R$ 28,22\n";
                        total = total + 28.22;
                        contador = contador + 1;
                        quantidadeSanduíches = quantidadeSanduíches + 1;
                    }
                    else if (opcaoDesejada == 12)
                    {
                        podutoEscolhido = podutoEscolhido + "Pizzas       Calabresa                                    R$ 8,98 \n";
                        total = total + 8.98;
                        contador = contador + 1;
                        quantidadePizzas = quantidadePizzas + 1;
                    }
                    else if (opcaoDesejada == 13)
                    {
                        podutoEscolhido = podutoEscolhido + "Pizzas       Napolitana                                   R$ 0,42 \n";
                        total = total + 0.42;
                        contador = contador + 1;
                        quantidadePizzas = quantidadePizzas + 1;

                    }
                    else if (opcaoDesejada == 14)
                    {
                        podutoEscolhido = podutoEscolhido + "Pizzas       Peruana                                      R$ 18,36\n";
                        total = total + 18.36;
                        contador = contador + 1;
                        quantidadePizzas = quantidadePizzas + 1;
                    }
                    else if (opcaoDesejada == 15)
                    {
                        podutoEscolhido = podutoEscolhido + "Pizzas       Portuguesa                                   R$ 27,50\n";
                        total = total + 27.50;
                        contador = contador + 1;
                        quantidadePizzas = quantidadePizzas + 1;
                    }
                    else
                    {
                        Console.Write("Não contem o código informado: ");
                        Console.ReadLine();

                    }
                }
                else
                {
                    loop = false;
                }
                
                Console.Clear();
            }
            Console.WriteLine(@"
Produtos:" +
podutoEscolhido + "" +
"\nTotal:" + total + "F" +
"\nBolos: " + quantidadeBolos +
"\nDoces: " + quantidadeDoces +
"\nSanduíches: " + quantidadeSanduíches +
"\nPizzas: " + quantidadePizzas);
            Console.ReadLine();
        }
    }
}
