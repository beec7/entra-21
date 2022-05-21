using Entra21.ExerciciosVetor;

var loop = true;

while (loop == true)
{
    var validar = false;
    var opcaoDesejada = 0;
    while (validar == false)
    {

        try
        {
            Console.Clear();
            Console.WriteLine(@"Opções:
1 - Exercicio01
2 - Exercicio02
3 - Exercicio03
4 - Exercicio04
5 - Exercicio05
6 - Exercicio06
7 - Exercicio07
8 - Exercicio08
9 - Exercicio09
20 - Exercicio20
99 - sair");

            Console.Write("Opção desejada: ");
            opcaoDesejada = Convert.ToInt32(Console.ReadLine());
            if (opcaoDesejada > 0 && opcaoDesejada < 100)
            {
                validar = true;
            }
            else
            {
                Console.Write("Escolha um número da lista");
                Console.ReadKey();
            }
        }
        catch
        {
            Console.WriteLine("Caracter Invalido");
            Console.ReadKey();
        }

        if (opcaoDesejada == 1)
        {
            var exercicio01 = new Exercicio01();
            exercicio01.Executar();
        }
        else if (opcaoDesejada == 2)
        {
            var exercicio02 = new Exercicio02();
            exercicio02.Executar();
        }
        else if (opcaoDesejada == 3)
        {
            var exercicio03 = new Exercicio03();
            exercicio03.Executar();

        }
        else if (opcaoDesejada == 4)
        {
            var exercicio04 = new Exercicio04();
            exercicio04.Executar();
        }
        else if (opcaoDesejada == 5)
        {
            var exercicio05 = new Exercicio05();
            exercicio05.Executar();
        }
        else if (opcaoDesejada == 6)
        {
            var exercicio06 = new Exercicio06();
            exercicio06.Executar();
        }
        else if (opcaoDesejada == 7)
        {
            var exercicio07 = new Exercicio07();
            exercicio07.Executar();
        }
        else if (opcaoDesejada == 8)
        {
            var exercicio08 = new Exercicio08();
            exercicio08.Executar();
        }
        else if (opcaoDesejada == 9)
        {
            var exercicio09 = new Exercicio09();
            exercicio09.Executar();
        }else if (opcaoDesejada == 10)
        {
            var exercicio10 = new Exercicio10();
            exercicio10.Executar();
        }else if (opcaoDesejada == 11)
        {
            var exercicio09 = new Exercicio09();
            exercicio09.Executar();
        }
        else if (opcaoDesejada == 20)
        {
            var exemploProfessor = new ExemploProfessor();
            exemploProfessor.Executar();
        }
        else if (opcaoDesejada == 99)
        {
            loop = false;
        }

    }
}
