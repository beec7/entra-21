using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExercicioListObjeto.Exercicio01
{
    internal class TrianguloControlador
    {
        private TrianguloConsolador trianguloServico = new TrianguloConsolador();
        public void GerenciarMenu()
        {
            var codigo = 0;
            while (codigo != 6)
            {
                Console.Clear();
                codigo = ApresentarMenu();

                Console.Clear();

                if (codigo == 1)
                {
                    ApresentarTriangulos();
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

                Console.WriteLine("Precione qualquer tecla para Continuar");
                Console.ReadKey();

            }

        }
        private int ApresentarMenu()
        {
            Console.WriteLine(@" Menu:
1 - Listar Todos
2 - Cadastrar
3 - Editar
4 - Apagar
5 - Apresentar Triangulo desejado
6 - sair");
            var codigo = SolicitarCodigo();
            return codigo;
        }
        private int SolicitarCodigo()
        {
            var codigo = 0;

            while (codigo < 1 || codigo > 6)
            {
                try
                {
                    Console.Write("Informe opção desejada: ");
                    codigo = Convert.ToInt32(Console.ReadLine());

                }
                catch (Exception ex)
                {
                    Console.Write("Valor invalido.\nInforme o Valor desejado do menu: ");
                }
            }
            return codigo;
        }

        private void ApresentarTriangulos()
        {
            var triangulos = trianguloServico.ObterTodos();

            Console.WriteLine("Lista de Triangulos");
            for (int i = 0; i < triangulos.Count; i++)
            {
                var trianguloAtual = triangulos[i];
                Console.WriteLine($@"Lado número 1: {trianguloAtual.Lado1}
Lado número 2: {trianguloAtual.Lado2}
Lado número 3: {trianguloAtual.Lado3}");

            }
        }
    }
}
