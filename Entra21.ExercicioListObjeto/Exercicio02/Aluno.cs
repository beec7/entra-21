using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExercicioListObjeto.Exercicio02
{
    internal class Aluno
    {
        public string Nome;
        public int CodigoMatricula; 
        public int Idade; 
        public string MateriaFavorita;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double CalcularMedia()
        {
            var media = (Nota1 + Nota2 + Nota3) / 3;
            return media;
        }
        public AlunoStatus ObterStatus()
        {
            if (CalcularMedia() >= 7)
            {
            return AlunoStatus.Aprovado;
            }
            if (CalcularMedia() >= 4)
            {
            return AlunoStatus.Exame;
            }
            return AlunoStatus.Reprovado;
        }
    }
}
