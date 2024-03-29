﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosListasObjetos
{
    internal class ProdutoControlador
    {
        private ProdutoServico produtoServico = new ProdutoServico();
        public void GerenciarMenu()
        {
            int codigo = 0;
            //Repete enquanto o código não for o menu sair(6)
            while (codigo != 6)
            {
                Console.Clear();

                //Apresentar o menu e solicita o codigo
                codigo = ApresentarSolicitarMenu();

                Console.Clear();

                if (codigo == 1)
                {
                    //Menu escolhido para listar produtos
                    ApresentarProdutos();

                }
                else if (codigo == 2)
                {
                    //Menu escolhido para cadastrar produto
                    Cadastrar();
                }
                else if (codigo == 3)
                {
                    //Menu escolhido para editar produto
                    Editar();
                }
                else if (codigo == 4)
                {
                    Apagar();
                }
                else if (codigo == 5)
                {
                    ApresentarProduto();
                }
                Console.Write("\n\nDigite alguma tecla para continuar...");
                Console.ReadKey();
            }
        }
        private void ApresentarProduto()
        {
            ApresentarProduto();

            Console.Write("Digite o código do produto a ser detalhado: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            var produto = produtoServico.ObterPorCodigo(codigo);

            //Verifica se o produto não esta cadastrado na lista de produtos
            if(produto == null)
            {
                Console.Write("Produto não cadastrado");
                return;
            }
            Console.Clear();
            Console.Write(@"Código: " + produto.Codigo +
                "\nNome: " + produto.Nome +
                "\nPreço unitário: " + produto.PrecoUnitario +
                "\nQuantidade: " + produto.Quantidade +
                "\nTotal: " + produto.CalcularPrecoTotal());
               
        }
            private void Apagar()
            {
                ApresentarProdutos();

                Console.Write("Digite o código do produto para apagar: ");
                int codigo = Convert.ToInt32(Console.ReadLine());

                var registroApagado = produtoServico.Apagar(codigo);

                Console.Write(registroApagado == true
                    ? "Registro removido com sucesso"
                    : "Nenhum produto cadastrado com codigo informado");
            }
        private void Editar()
        {
            ApresentarProdutos();

            Console.Write("Código produto desejado: ");
            var codigo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nome: ");
            var nome = Console.ReadLine();

            Console.Write("Quantidade: ");
            var quantidade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Preço unitário: ");
            var precoUnitario = Convert.ToDouble(Console.ReadLine());

            Console.Write(@"Localizações disponíveis: 
- Armazem
- Area Venda
- Loja");
            Console.Write("Localização: ");
            var localizacao = Console.ReadLine();

            var localizacaoProduto = ObterLocalizacaoProduto(localizacao);

            var alterou = produtoServico.Editar(codigo, nome, precoUnitario, localizacaoProduto, quantidade);

            if (alterou == false)
            {
                Console.Write("Código digitado não existe");

            }
            else
            {
                Console.Write("Produto alterado com sucesso");
            }
        }
        private int ApresentarSolicitarMenu()
        {
            Console.WriteLine(@" Menu:
1 - Listar todos
2 - Cadastrar
3 - Editar
4 - Apagar
5 - Apresentar produto desejado
6 - Sair");

            int codigo = SolicitarCodigo();
            return codigo;
        }
        private int SolicitarCodigo()
        {
            int codigo = 0;
            //Continua solicitando o código até que seja um código entre 1 e 6
            while (codigo < 1 || codigo > 6)
            {
                try
                {
                    Console.Write("Digite o seu código");
                    codigo = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.Write("Digite um menu válido");
                }
            }
            return codigo;
        }
        private void Cadastrar()
        {
            Console.Write("Nome: ");
            var nome = Console.ReadLine();

            Console.Write("Quantidade: ");
            var quantidade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Preço Unitário: ");
            var precoUnitario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(@"Localizações disponíveis: 
- Armazem
- Area Venda
- Loja");


            Console.Write("Localização: ");
            var localizacao = Console.ReadLine();

            var localizacaoProduto = ObterLocalizacaoProduto(localizacao);

            produtoServico.Adicionar(nome, precoUnitario, localizacaoProduto, quantidade);
        }
        private ProdutoLocalizacao ObterLocalizacaoProduto(string localizacao)
        {
            if (localizacao.ToLower() == "armazem")
            {
                return ProdutoLocalizacao.Armazem;
            }
            else if (localizacao.ToLower() == "loja")
            {
                return ProdutoLocalizacao.Loja;
            }
            else
            {
                return ProdutoLocalizacao.AreaVenda;
            }
        }
        private void ApresentarProdutos()
        {
            var produtos = produtoServico.ObterTodos();
            if (produtos.Count == 0)
            {
                Console.WriteLine("Nenhum produto cadastrado :(");
                //Para a execução deste método
                return;
            }
            Console.WriteLine("Lista de Produtos");
            for (var i = 0; i < produtos.Count; i++)
            {
                var produtoAtual = produtos[i];

                Console.Write(
                    "\nCódigo: " + produtoAtual.Codigo +
                    "\nNome: " + produtoAtual.Nome + "\n");
            }
        }
    }
}

