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
        Console.WriteLine("" +
            "1 - Exercicio 01 While\n" +
            "2 - Exercicio 05 While\n" +
            "3 - Exercicio 08 While\n" +
            "4 - Exercicio 10 While\n" +
            "5 - Exercicio 12 While\n" +
            "6 - Exercicio 13 While\n" +
            "99 - Sair");
        try
        {
            Console.WriteLine("Informe a opção desejada");
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
            else
            {
                Console.WriteLine("Não corresponde a uma opção existente.");
            }
            
        }
        else
        {
            loop = false;
        }
    }

}