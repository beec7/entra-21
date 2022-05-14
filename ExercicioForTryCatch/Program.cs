
var loop = true;

while (loop == true)
{
    var opcaoValida = false;
    var opcaoDesejada = 0;
    while (opcaoValida == false)
    {
        try
        {
            Console.Write("Informe a opção desejada");
            opcaoDesejada = Convert.ToInt32(Console.ReadLine());
            if(opcaoDesejada <= 0)
            {
                Console.Write("Não tem opção negaiva:");
            }
            else
            {
                opcaoValida = true;
            }
        }
        catch (Exception ex)
        {
            Console.Write("Informe o número da opção");
        }
    }

}