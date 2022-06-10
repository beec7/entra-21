using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExercicioListObjeto.Exercicio01
{
    internal class TrianguloControlador
    {
        private TrianguloServico trianguloServico = new TrianguloServico();
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
                    CadastrarTriangulo();
                }
                else if (codigo == 3)
                {
                    EditarTriangulo();
                }
                else if (codigo == 4)
                {
                    Apagar();
                }
                else if (codigo == 5)
                {
                    ApresentarTriangulo();
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
                Console.WriteLine($@"Código : {trianguloAtual.Codigo}
Lado número 1: {trianguloAtual.Lado1} Lado número 2: {trianguloAtual.Lado2} Lado número 3: {trianguloAtual.Lado3}

");
            }
        }
        private void CadastrarTriangulo()
        {
            Console.Write("Primeiro valor do Triangulo: ");
            var lado1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Segundo valor do Triangulo: ");
            var lado2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Terceiro valor do Triangulo: ");
            var lado3 = Convert.ToInt32(Console.ReadLine());

            trianguloServico.Adicionar(lado1, lado2, lado3);

        }
        private void EditarTriangulo()
        {
            ApresentarTriangulos();

            Console.Write("Código do Triangulo: ");
            var codigo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Primeiro valor do Triangulo: ");
            var lado1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Segundo valor do Triangulo: ");
            var lado2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Terceiro valor do Triangulo: ");
            var lado3 = Convert.ToInt32(Console.ReadLine());

            var alterouTriangulo = trianguloServico.Editar(codigo, lado1, lado2, lado3);

            if (alterouTriangulo == true)
            {
                Console.Write("Alterado com sucesso");
            }
            else
            {
                Console.Write("Não encontrado");
            }
        }
        private void Apagar()
        {
            ApresentarTriangulos();
            Console.Write("Código para deletar:");
            var codigo = Convert.ToInt32(Console.ReadLine());

            var registroApagar = trianguloServico.Apagar(codigo);

            Console.WriteLine(registroApagar == true
               ? "Registro removido com sucesso"
               : "Nenhum produto cadastrado com o codigo informado");

        }
        private void ApresentarTriangulo()
        {
            ApresentarTriangulos();
            Console.Write("Informe o Código: ");
            var codigo = Convert.ToInt32(Console.ReadLine());

            var triangulo = trianguloServico.ObterPorCodigo(codigo);

            if (triangulo == null)
            {
                Console.Write("Triangulo não encontrado");
                return;
            }

            Console.Clear();
Console.WriteLine($@"Código : {triangulo.Codigo}

Lado número 1: {triangulo.Lado1}

Lado número 2: {triangulo.Lado2}

Lado número 3: {triangulo.Lado3}

Triangulo ?: {triangulo.ValidorTriangulo()}

");
       
        }
    }
}
