namespace Entra21.ExercicioListObjeto.Exercicio01
{
    internal class Triangulo
    {
        public int Lado1;
        public int Lado2;
        public int Lado3;
        public int Codigo;

        public bool ValidorTriangulo()
        {
            if (IsLadoValido(Lado1, Lado2, Lado3) &&
                IsLadoValido(Lado2, Lado3, Lado1) &&
                IsLadoValido(Lado3, Lado1, Lado2))
            {
                return true;
            }

            return false;
        }
        private bool IsLadoValido(int valor1, int valor2, int valor3)
        {
            if ((valor1 - valor2) < valor3 && (valor1 + valor2) > valor3)
            {
                return true;
            }
            return false;
        }
    }
}
