using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosListaObjetos
{
    internal class TrianguloControlador
    {
        private TrianguloServico trianguloServico = new TrianguloServico();

        public void GerenciarMenuTriangulo()
        {
            int codigo = 0;
            while (codigo != 6)
            {
                Console.Clear();
                codigo = ApresentarTriangulos();

                Console.Clear();
            }
        }
        private void Editar()
        {
            ApresentarTriangulos();
            Console.Write("Código do triangulo desejado: ");
            var codigo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lado 1: ");
            var lado1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lado 2: ");
            var lado2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lado 3: ");
            var lado3 = Convert.ToInt32(Console.ReadLine());

            var alterou = trianguloServico.Editar(codigo, lado1, lado2, lado3);

            if(alterou == false)
            {
                Console.Write("código digitado não existe");
            }
            else
            {
                Console.WriteLine("Produto alterado com sucesso");
            }
        }
        private void Apagar()
        {
            ApresentarTriangulo();

            Console.Write("Digite o código do triângulo para ser apagado");
            int codigo = Convert.ToInt32(Console.ReadLine());

            var registroApagado = trianguloServico.Apagar(codigo);

            Console.Write(registroApagado == true
                ? "Registro removido com sucesso"
                : "Nenhum triangulo cadastrado com o código informado");
        }
        pri
        private void ApresentarTriangulo()
        {
            ApresentarTriangulo();
            Console.Write("Digite o código do triangulo a ser detalhado: ");
            int codigo = Convert.ToInt32(Console.ReadLine());
            var triangulo = trianguloServico.ObterPorCodigo(codigo);

            if (triangulo == null)
            {
                Console.Write("Produto não cadastrado :(");
                return;
            }

            Console.Clear();
            Console.Write(@"Código: " + triangulo.Codigo +
                "\nLado1: " + triangulo.Lado1 +
                "\nLado2: " + triangulo.Lado2 +
                "\nLado3: " + triangulo.Lado3);
        }
        private void CadastrarTriangulo()
        {
            Console.Write("Informe o valor do primeiro lado do triângulo: ");
            int lado1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe o valor do segundo lado do triângulo: ");
            var lado2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe o valor do terceiro lado do triângulo: ");
            var lado3 = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            Console.Write("lado 1 cadastrado com valor de: " + lado1 +
                "\nLado 2 cadastrado com valor de: " + lado2 +
                "\nLado 3 cadastrado com valor de: " + lado3);
        }
        private void ApresentarTriangulos()
        {
            var triangulos = trianguloServico.ObterTodos();
            if (triangulos.Count == 0)
            {
                Console.Write("Nenhum produto encontrado :(");
                return;
            }
            Console.Write("Lista de produtos");
            for (var i = 0; i < triangulos.Count; i++)
            {
                var trianguloAtual = triangulos[i];

                Console.Write(
                    "\nCódigo: " + trianguloAtual.Codigo +
                    "\nLado1: " + trianguloAtual.Lado1 +
                    "\nLado2: " + trianguloAtual.Lado2 +
                    "\nLado3: " + trianguloAtual.Lado3);
            }
        }
    }
}
