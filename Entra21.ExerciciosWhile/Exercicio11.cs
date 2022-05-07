using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio11
    {
        public void Executar()
        {
            /*11. Solicite para o usuário dois números. Apresente o seguinte menu e de acordo com a
            escolha deve ser apresentado a operação aritmética, isto deve ocorrer até que o
            mesmo escolha a opção de sair:

            MENU
            1 Somar
            2 Subtrair
            3 Multiplicar
            4 Dividir
            5 Sair
            Continua na próxima página....*/
            bool loop = true;

            while (loop == true)
            {
                Console.Clear();
                Console.Write("Informe o primeiro número: ");
                double numero1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Informe o segundo número: ");
                double numero2 = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                Console.WriteLine(@"       MENU
            1                Somar
            2                Subtrair
            3                Multiplicar
            4                Dividir
            5                Sair
Informe o número da opção desejada");
                int opcaoDesejada = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (opcaoDesejada == 1)
                {
                    Console.WriteLine(numero1 + " + " + numero2 + " = " + (numero1 + numero2));
                    Console.ReadKey();
                }
                else if (opcaoDesejada == 2)
                {
                    Console.WriteLine(numero1 + " - " + numero2 + " = " + (numero1 - numero2));
                    Console.ReadKey();
                }
                else if (opcaoDesejada == 3)
                {
                    Console.WriteLine(numero1 + " x " + numero2 + " = " + (numero1 * numero2));
                    Console.ReadKey();
                }
                else if(opcaoDesejada == 4)
                {
                    Console.WriteLine(numero1 + " / " + numero2 + " = " + (numero1 / numero2));
                    Console.ReadKey();
                }
                else if (opcaoDesejada == 5)
                {
                    loop = false;
                }
                else
                {
                    Console.Write(" Erro 404 - Opção invalida");
                    Console.ReadKey();
                }


            }
        }
    }
}
