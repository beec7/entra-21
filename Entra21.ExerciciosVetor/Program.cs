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

        }
        else if (opcaoDesejada == 4)
        {

        }
        else if (opcaoDesejada == 5)
        {

        }
        else if (opcaoDesejada == 6)
        {

        }
        else if (opcaoDesejada == 7)
        {

        }
        else if (opcaoDesejada == 99)
        {
            loop = false;
        }

    }
}
