namespace Entra21.ExercicioListObjeto.Exercicio01
{
    internal class TrianguloServico
    {
        private List<Triangulo> triangulos = new List<Triangulo>();
        private int CodigoAtual = 1;

        public bool Adicionar(int lado1, int lado2, int lado3)
        {
            Triangulo triangulo = new Triangulo();
            triangulo.Lado1 = lado1;
            triangulo.Lado2 = lado2;
            triangulo.Lado3 = lado3;
            triangulo.Codigo = CodigoAtual;
            CodigoAtual += 1;
            triangulos.Add(triangulo);

            return true;
        }

        public bool Editar(int codigoAlterar, int lado1, int lado2, int lado3)
        {
            Triangulo trianguloParaAlterar = ObterPorCodigo(codigoAlterar);

            if (trianguloParaAlterar == null)
            {
                return false;
            }

            trianguloParaAlterar.Lado1 = lado1;
            trianguloParaAlterar.Lado2 = lado2;
            trianguloParaAlterar.Lado3 = lado3;

            return true;
        }

        public bool Apagar(int codigoApagar)
        {
            Triangulo trianguloParaApagar = ObterPorCodigo(codigoApagar);

            if (trianguloParaApagar == null)
            {
                return false;
            }

            triangulos.Remove(trianguloParaApagar);

            return true;
        }

        public List<Triangulo> ObterTodos()
        {
            return triangulos;
        }

        public Triangulo ObterPorCodigo(int codigo)
        {
            for (int i = 0; i < triangulos.Count; i++)
            {
                var trianguloAtual = triangulos[i];

                if (trianguloAtual.Codigo == codigo)
                {
                    return trianguloAtual;
                }
            }
            return null;
        }
    }
}
