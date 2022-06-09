﻿using ExemplosListasObjetos;

namespace Entra21.ExemplosListasObjetos
{
    internal class ProdutoServico
    {
        private List<Produto> produtos = new List<Produto>();

        public void Adicionar(string nome, double precoUnitario, ProdutoLocalizacao localizacao, int quantidade) 
        { 
            
            //Instanciar um objeto da classe produto
            Produto produto = new Produto();

            //Atribuir valor para as propriedades com os passados como parâmetro
            produto.Nome = nome;
            produto.PrecoUnitario = precoUnitario;
            produto.Localizacao = localizacao;
            produto.Quantidade = quantidade;

            //Adicionar o produto instanciado na lista
            produtos.Add(produto);
        }
        public void Editar() { }
        public void Apagar() { }
        public List <Produto> ObterTodos()
        {
            return produtos;
        }
        public Produto ObterPorCodigo()
        {
            return null;
        }
    }
}
