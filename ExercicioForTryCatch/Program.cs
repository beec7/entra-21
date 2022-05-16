using ExercicioForTryCatch;
var loop = true;


//fazer as questões: 1, 5, 8, 10, 12, 13
//da lista 3
while (loop == true)
{
    var opcaoValida = false;
    var opcaoDesejada = 0;
    while (opcaoValida == false)
    {
        Console.Clear();
        Console.Write("" +
            "1 - Exercicio 01 While\n" +
            "2 - Exercicio 05 While\n" +
            "3 - Exercicio 08 While\n" +
            "4 - Exercicio 10 While\n" +
            "5 - Exercicio 12 While\n" +
            "6 - Exercicio 13 While\n" +
            "99 - Sair");
        try
        {
            Console.Write("Informe a opção desejada");
            opcaoDesejada = Convert.ToInt32(Console.ReadLine());
            if (opcaoDesejada <= 0)
            {
                Console.Write("Não tem opção negaiva:");
                Console.ReadKey();
            }
            else
            {
                opcaoValida = true;
            }
        }
        catch (Exception ex)
        {
            Console.Write("Informe o número da opção");
            Console.ReadKey();
        }


        if (opcaoDesejada != 99)
        {
            if (opcaoDesejada == 1)
            {
                var exercicio01 = new Exercicio01();
                exercicio01.Executar();
            }

        }
        else
        {
            loop = false;
        }
    }

}