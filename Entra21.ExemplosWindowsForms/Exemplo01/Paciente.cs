namespace Entra21.ExemplosWindowsForms.Exemplo01
{
    internal class Paciente
    {
        public int Codigo;
        public string Nome;
        public double Alutera;
        public double Peso;

        public double ObterImc()
        {
            return Peso / Math.Pow(Alutera, 2);
        }
    }
}
