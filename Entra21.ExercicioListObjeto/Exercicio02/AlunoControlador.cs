using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExercicioListObjeto.Exercicio02
{
    internal class AlunoControlador
    {
        public void GerenciarMenu()
        {
            var codigo = ApresentarMenu();
            while (codigo != 99)
            {
                Console.Clear();

                if (codigo == 1)
                {

                }
                else if (codigo == 2)
                {

                }
                else if (codigo == 3)
                {

                }
                else if (codigo == 4)
                {

                }
                else if (codigo == 5)
                {

                }
                else if (codigo == 6)
                {

                }
                else if (codigo == 7)
                {

                }
                else if (codigo == 8)
                {

                }
                else if (codigo == 9)
                {

                }
                else if (codigo == 10)
                {

                }
                else if (codigo == 11)
                {

                }
                else if (codigo == 12)
                {

                }

            }
        }
        //- Permitir cadastrar alunos;
        //- Permitir listar o nome de todos os alunos;
        //- Permitir listar todos os alunos;
        //- Permitir editar as informações básicas do aluno;
        //- Permitir alterar as notas do aluno;
        //- Permitir apagar um aluno com o nome do aluno que o usuário digitou;
        //- Permitir visualizar a média das idades.

        //- Permitir o usuário escolher qual função deseja executar
        //- Permitir listar o nome dos aprovados;
        //- Permitir listar o nome dos reprovados;
        //- Permitir listar o nome dos alunos em exame;
        //- Permitir visualizar a média de um aluno específico;
        //- Permitir visualizar o status de um aluno específico;
        private int ApresentarMenu()
        {
            Console.WriteLine(@"   Menu:
1 - Cadastrar aluno.
2 - Listar o nome de todos os alunos.
3 - Listar todos os alunos.
4 - Editar infomações básica dos alunos.
5 - Alterar as notas dos alunos.
6 - Apagar um aluno no o nome.
7 - Mostrar a média de idade dos alunos.
8 - Lista de APROVADOS. 
9 - Lista de EM EXAME.
10 - Lista de REPROVADO.
11 - Média de um aluno.
12 - Mostrar o status atual do aluno.
99 - SAIR.
");

            var codigo = SolicitarCodigo();
            return codigo;
        }
        private int SolicitarCodigo()
        {
            var codigo = 0;

            while (codigo < 1 || codigo > 16 || codigo == 99)
            {
                try
                {
                    Console.Write("Imforme a opção desejada: ");
                    codigo = Convert.ToInt32(Console.ReadLine());

                }
                catch (Exception ex)
                {
                    Console.Write("Imforme um código invalido, Informe novamente: ");
                }
            }
            return codigo;
        }


    }
}
