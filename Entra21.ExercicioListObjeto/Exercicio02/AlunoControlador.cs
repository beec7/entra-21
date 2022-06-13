namespace Entra21.ExercicioListObjeto.Exercicio02
{
    internal class AlunoControlador
    {
        private AlunoServico alunoServico = new AlunoServico();
        public void GerenciarMenu()
        {
            Console.Clear();
            var codigo = ApresentarMenu();
            while (codigo != 99)
            {
                Console.Clear();

                if (codigo == 1)
                {
                    AdicionarAluno();
                }
                else if (codigo == 2)
                {
                    ObterListaNomes();
                }
                else if (codigo == 3)
                {
                    ListarTodosAlunos();
                }
                else if (codigo == 4)
                {
                    EditarInformacaoBaseAluno();
                }
                else if (codigo == 5)
                {
                    EditarNotasAluno();
                }
                else if (codigo == 6)
                {
                    ApagarAluno();
                }
                else if (codigo == 7)
                {
                    MediaIdade();
                }
                else if (codigo == 8)
                {
                    ListarAprovados();
                }
                else if (codigo == 9)
                {
                    ListarEmExame();
                }
                else if (codigo == 10)
                {
                    ListarReprovados();
                }
                else if (codigo == 11)
                {
                    ObterMediaPorCodigoMatricula();
                }
                else if (codigo == 12)
                {

                }

            }
        }

        //- Permitir o usuário escolher qual função deseja executar
        //1- Permitir cadastrar alunos;
        //2- Permitir listar o nome de todos os alunos;
        //3- Permitir listar todos os alunos;
        //4- Permitir editar as informações básicas do aluno;
        //5- Permitir alterar as notas do aluno;
        //6- Permitir apagar um aluno com o nome do aluno que o usuário digitou;
        //7- Permitir visualizar a média das idades.
        //8- Permitir listar o nome dos aprovados;
        //9- Permitir listar o nome dos reprovados;
        //10- Permitir listar o nome dos alunos em exame;
        //11- Permitir visualizar a média de um aluno específico;
        //12- Permitir visualizar o status de um aluno específico;
        private int ApresentarMenu()
        {
            Console.WriteLine(@"   Menu:
1 - Cadastrar aluno.
2 - Listar o nome de todos os alunos.
3 - Listar todos os alunos.
4 - Editar infomações básica dos alunos.
5 - Alterar as notas dos alunos.
6 - Apagar um aluno pelo o nome.
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

        private void AdicionarAluno()
        {
            Console.Write("Nome: ");
            var nome = Console.ReadLine();
            Console.Write("Idade: ");
            var idade = Convert.ToInt32(Console.ReadLine());
            Console.Write("Materia Favorita: ");
            var materiaFavorita = Console.ReadLine();
            Console.Write("Nota1: ");
            var nota1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nota2: ");
            var nota2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nota3: ");
            var nota3 = Convert.ToDouble(Console.ReadLine());

            alunoServico.AdicionarAluno(nome, idade, materiaFavorita, nota1, nota2, nota3);
        }
        private void ListarTodosAlunos()
        {
            var alunos = alunoServico.ObterTodosAlunos();
            if (alunos != null)
            {
                for (int i = 0; i < alunos.Count; i++)
                {
                    var alunoAtual = alunos[i];
                    Console.Write($@"Código matricula: {alunoAtual.CodigoMatricula}
Nome: {alunoAtual.Nome}
Idade: {alunoAtual.Idade}
Materia favorita: {alunoAtual.MateriaFavorita}
Nota1: {alunoAtual.Nota1}
Nota2: {alunoAtual.Nota2}
Nota3: {alunoAtual.Nota3}
");

                }
            }
        }

        private void ObterListaNomes()
        {
            var nomes = alunoServico.ObterNomes();
            if (nomes != null)
            {
                for (int i = 0; i < nomes.Count; i++)
                {
                    Console.WriteLine(nomes[i]);
                }
                return;
            }
            Console.WriteLine("Cadaste alunos antes");
        }

        private void EditarInformacaoBaseAluno()
        {
            ListarTodosAlunos();

            Console.Write("\nInforme o código de matricula: ");
            var codigoMatricula = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nome: ");
            var nome = Console.ReadLine();
            Console.Write("Idade: ");
            var idade = Convert.ToInt32(Console.ReadLine());
            Console.Write("Matéria favorita: ");
            var materiaFavorita = Console.ReadLine();

            var alterou = alunoServico.EditarDadosCadastrais(codigoMatricula, nome, idade, materiaFavorita);


            if (alterou == true)
            {
                Console.WriteLine("Alterado com sucesso");
            }
            else
            {
                Console.WriteLine("nao encontrado");
            }

        }

        private void EditarNotasAluno()
        {
            ListarTodosAlunos();
            Console.Write("Código Matriculama: ");
            var codigoMatricula = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nota 1:");
            var nota1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nota 2:");
            var nota2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nota 3:");
            var nota3 = Convert.ToDouble(Console.ReadLine());

            var alterou = alunoServico.EditarNotasAluno(codigoMatricula, nota1, nota2, nota3);

            if (alterou == true)
            {
                Console.WriteLine("Alterado com sucesso");
            }
            else
            {
                Console.WriteLine("nao encontrado");
            }

        }

        private void ApagarAluno()
        {
            ListarTodosAlunos();
            Console.Write("\nInforme o nome do aluno para apagar: ");
            var nome = Console.ReadLine();

            var validarRemovar = alunoServico.RemoverAluno(nome);

            if (validarRemovar == true)
            {
                Console.Write("Aluno removido com sucesso");
            }
            else
            {
                Console.Write("Aluno não encontrado");
            }

        }

        private void MediaIdade()
        {
            Console.WriteLine("Média de idade: " + alunoServico.ObterMediaIdades());
        }

        private void ListarAprovados()
        {
            var aprovados = alunoServico.ObterAprovados();

            Console.WriteLine("Lista de APROVADOS");

            for (int i = 0; i < aprovados.Count; i++)
            {
                Console.WriteLine(aprovados[i]);
            }
        }

        private void ListarEmExame()
        {
            var emExame = alunoServico.ObterEmExame();

            Console.WriteLine("Lista de EM EXAME");

            for (int i = 0; i < emExame.Count; i++)
            {
                Console.WriteLine(emExame[i]);
            }
        }

        private void ListarReprovados()
        {
            var reprovado = alunoServico.ObterReprovados();

            Console.WriteLine("Lista de REPROVADO");

            for (int i = 0; i < reprovado.Count; i++)
            {
                Console.WriteLine(reprovado[i]);
            }
        }

        private void ObterMediaPorCodigoMatricula()
        {
            ListarTodosAlunos();
            
            Console.Write("\nInforme o código da matricula para ver a média: ");
            var codigoMatricula = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("A média do aluno: " + alunoServico.ObterMediaPorCodigoMatricula(codigoMatricula));
        }

        private void ObterStatusPorCodigoMatricula()
        {
            ListarTodosAlunos();

            Console.Write("\nInforme o código da matricula para ver o Status: ");
            var codigoMatricula = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("O status do aluno: " + alunoServico.ObterStatusProCodigoMatricula(codigoMatricula));
        }
    }
}
