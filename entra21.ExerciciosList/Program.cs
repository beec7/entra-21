using entra21.ExerciciosList.Exercicio01;
using entra21.ExerciciosList.Exercicio02;
using entra21.ExerciciosList.Exercicio03;

Console.WriteLine(" 1 = Exercicio 01" +
    "\n2 = Exercicio 02" +
    "\n3 = Exercicio 03");
var opcao = Convert.ToInt32(Console.ReadLine());

if (opcao == 1)
{
    ExecutarMelhoresFilmesTodosTempos executar = new ExecutarMelhoresFilmesTodosTempos();
    executar.Executar();

}
else if (opcao == 2)
{
    ConteudoPassado couteudo = new ConteudoPassado();
    couteudo.Executar();

}
else if (opcao == 3)
{
Notas notas = new Notas();
notas.Executar();

}
