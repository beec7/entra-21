namespace Entra21.ExercicioListObjeto.Exercicio02
{
    internal class AlunoServico
    {
        private List<Aluno> alunos = new List<Aluno>();
        private int CodigoAtual = 0;

        public void AdicionarAluno(string nome, int idade,
            string materialFavorita, int codigoMatricula,
            double nota1, double nota2, double nota3)
        {
            Aluno aluno = new Aluno();
            aluno.Nome = nome;
            aluno.Idade = idade;
            aluno.MateriaFavorita = materialFavorita;
            aluno.Nota1 = nota1;
            aluno.Nota2 = nota2;
            aluno.Nota3 = nota3;

            aluno.CodigoMatricula = CodigoAtual;
            CodigoAtual += 1;

            alunos.Add(aluno);

        }

        //Obtem por Nome
        public Aluno ObterPorNome(string nome)
        {
            for (int i = 0; i < alunos.Count; i++)
            {
                Aluno aluno = alunos[i];
                if (aluno.Nome == nome)
                {
                    return aluno;
                }
            }
            return null;

        }

        //Obtem por Codigo de Matricula
        public Aluno ObterPorCodigoMatricula(int codigoMatricula)
        {
            for (int i = 0; i < alunos.Count; i++)
            {
                Aluno aluno = alunos[i];
                if (aluno.CodigoMatricula == codigoMatricula)
                {
                    return aluno;
                }
            }
            return null;

        }

        public bool RemoverAluno(string nome)
        {
            Aluno aluno = ObterPorNome(nome);
            if (aluno == null)
            {
                return false;
            }
            alunos.Remove(aluno);
            return true;

        }

        public bool EditarDadosCadastrais(int codigoMatricula, string nome, int idade, string materialFavorita)
        {

            Aluno aluno = ObterPorCodigoMatricula(codigoMatricula);
            if (aluno == null)
            {
                return false;
            }
            aluno.Nome = nome;
            aluno.Idade = idade;
            aluno.MateriaFavorita = materialFavorita;

            return true;

        }

        public bool EditarNotasAluno(int codigoMatricula, double nota1, double nota2, double nota3)
        {
            Aluno aluno = ObterPorCodigoMatricula(codigoMatricula);
            if (aluno == null)
            {
                return false;
            }

            aluno.Nota1 = nota1;
            aluno.Nota2 = nota2;
            aluno.Nota3 = nota3;

            return true;
        }

        public List<string> ObterNomes()
        {
            List<string> nomes = new List<string>();

            if (alunos == null)
            {
                return null;
            }

            for (var i = 0; i < alunos.Count; i++)
            {
                nomes.Add(alunos[i].Nome);
            }
            return nomes;

        }

        public List<double> ObterMedias()
        {
            List<double> medias = new List<double>();

            if (alunos == null)
            {
                return null;
            }

            for (var i = 0; i < alunos.Count; i++)
            {
                medias.Add(alunos[i].CalcularMedia());
            }
            return medias;

        }

        public List<string> ObterAprovados()
        {
            List<string> aprovados = new List<string>();
            if (alunos == null)
            {
                return null;
            }
            for (int i = 0; i < alunos.Count; i++)
            {
                if ((alunos[i].ObterStatus()) == AlunoStatus.Aprovado)
                {
                    aprovados.Add(alunos[i].Nome);
                }
            }
            return aprovados;
        }

        public List<string> ObterReprovados()
        {
            List<string> reprovados = new List<string>();
            if (alunos == null)
            {
                return null;
            }
            for (int i = 0; i < alunos.Count; i++)
            {
                if ((alunos[i].ObterStatus()) == AlunoStatus.Reprovado)
                {
                    reprovados.Add(alunos[i].Nome);
                }
            }
            return reprovados;
        }

        public List<string> ObterEmExame()
        {
            List<string> EmExame = new List<string>();
            if (alunos == null)
            {
                return null;
            }
            for (int i = 0; i < alunos.Count; i++)
            {
                if ((alunos[i].ObterStatus()) == AlunoStatus.Em_exame)
                {
                    EmExame.Add(alunos[i].Nome);
                }
            }
            return EmExame;
        }

        public double ObterMediaPorCodigoMatricula(int codigoMatricula)
        {
            Aluno aluno = ObterPorCodigoMatricula(codigoMatricula);
            return aluno.CalcularMedia();
        }

        public double ObterMediaIdades()
        {
            var somaIdade = 0;
            for (int i = 0; i < alunos.Count; i++)
            {
                somaIdade += alunos[i].Idade;
            }
            return somaIdade / alunos.Count;
        }

        public AlunoStatus ObterStatusProCodigoMatricula(int codigoMatricula)
        {
            var aluno = ObterPorCodigoMatricula(codigoMatricula);

            return aluno.ObterStatus();

        }
    }
}
