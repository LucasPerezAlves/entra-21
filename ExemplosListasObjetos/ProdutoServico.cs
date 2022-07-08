using ExemplosListasObjetos;

namespace Entra21.ExemplosListasObjetos
{
    internal class ProdutoServico
    {
        private List<Produto> produtos = new List<Produto>();
        //Armazenar o código do próximo produto
        private int codigoAtual = 1;

        public void Adicionar(string nome, double precoUnitario, ProdutoLocalizacao localizacao, int quantidade)
        {

            //Instanciar um objeto da classe produto
            Produto produto = new Produto();

            //Atribuir valor para as propriedades com os passados como parâmetro
            produto.Nome = nome;
            produto.PrecoUnitario = precoUnitario;
            produto.Localizacao = localizacao;
            produto.Quantidade = quantidade;

            //Atribuir o código novo para o objeto do produto
            produto.Codigo = codigoAtual;

            //Adicionar 1 no código atual para quando criar um novo produto o produto conter o outro código
            codigoAtual = codigoAtual + 1;

            //Adicionar o produto instanciado na lista
            produtos.Add(produto);
        }
        public bool Editar(int codigoParaAlterar, string nome, double precoUnitario, ProdutoLocalizacao localizacao, int quantidade)
        {
            //Obtém o produto desejado da lista de produto
            Produto produtoParaAlterar = ObterPorCodigo(codigoParaAlterar);

            //Verifica senão foi possivel encontrar o produto
            if (produtoParaAlterar == null)
            {
                //Retorna falso pq não existe produto com o código dos parâmentros
                return false;
            }

            //Atualiza as propriedades (campos) do produto desejado
            produtoParaAlterar.Nome = nome;
            produtoParaAlterar.Localizacao = localizacao;
            produtoParaAlterar.PrecoUnitario = precoUnitario;
            produtoParaAlterar.Quantidade = quantidade;

            //Retorna verdadeiro pq foi possivel alterar o produto
            return true;
        }
        public bool Apagar(int codigo)
        {
            for (int i = 0; i < produtos.Count; i++)
            {
                //Resgatando de uma lista de tipos primitivos
                //int numero = numeros[i];
                //Resgatando de uma lista de objetos

                Produto produto = produtos[i];
                if (produto.Codigo == codigo)
                {
                    //Posso remover com o indice do objeto desejado
                    //produtos.RemoveAt(i);

                    //Posso remover com o objeto desejado
                    produtos.Remove(produto);
                    //Retorna verdadeiro pq o produto com o código desejado foi removido da lista
                    return true;
                }
            }
            //Retorna falso pq não foi encon trado produto com o código desejado, ou seja,
            //nenhum elemento foi removido da lista
            return false;

        }
        public List<Produto> ObterTodos()
        {
            return produtos;
        }
        public Produto ObterPorCodigo(int codigo)
        {
            //Percorrer todos os elementos para encontrar o produto filtrado por código
            for (int i = 0; i < produtos.Count; i++)
            {
                //Obter o produto da lista de produtos em determinado indice
                var produtoAtual = produtos[i];

                //Verifica se o produto atual da lista percorrida é o desejado
                if (produtoAtual.Codigo == codigo)
                {
                    //retorna o produto encontrado
                    return produtoAtual;
                }
            }
            //Retorna null, caso não encontrar um produto com o código passado como parâmetro
            return null;

        }
        public Produto ObterMenorPrecoUnitario()
        {
            double menorPrecoUnitario = double.MaxValue;
            Produto produtoMenorPrecoUnitario = null;
            //Percorre a lista de produtos para obter o produto com o menor preço unitário
            for (int i = 0; i < produtos.Count; i++)
            {
                //Obtem o produto atual da lista que esta sendo percorrida
                Produto produto = produtos[i];

                //Verifica se o produto atual possui o menor preço unitário
                if (produto.PrecoUnitario < menorPrecoUnitario)
                {
                    //Armazena o preço unitário, poois é o menor preço unitario até o momento
                    menorPrecoUnitario = produto.PrecoUnitario;

                    //Armazena o produto para posteriormente saber qual é o produto com o menor preço unitário
                    produtoMenorPrecoUnitario = produto;
                }
            }
            return produtoMenorPrecoUnitario;
        }
        public List<double> ObterTodosPrecos()
        {
            //Criar uma lista de preços totais
            var precos = new List<double>();
            //Percorre todos os produtos
            for (int i = 0; i < produtos.Count; i++)
            {
                //Obtém o produto atual da lista de produtos
                var produto = produtos[i];

                //Adiciona o preço total na lista de preços
                precos.Add(produto.CalcularPrecoTotal());
            }
            return precos;
        }
        public List<double> ObterPrecosTotaisFiltrandoPorLocalizacao(ProdutoLocalizacao localizacao)
        {
            //Criar uma lista de preços totais
            var precos = new List<double>();
            //Percorre todos os produtos
            for (var i = 0; i < produtos.Count; i++)
            {
                //Obtém o produto atual da lista de produtos
                var produto = produtos[i];

                //Verifica se a localização do produto atual é a localizacao passada no parametro
                if (produto.Localizacao == localizacao)
                {
                    //Adiciona o preco total do prdouto atual que foi filtrado por localização
                    precos.Add(produto.CalcularPrecoTotal());
                }
            }
            return precos;
        }

        public List<double> ObterPrecosTotaisDoArmazem()
        {
            //Criar uma lista de preços totais
            var precos = new List<double>();

            //Percorre todos os produtos
            for (int i = 0; i < produtos.Count; i++)
            {
                //Obtém o produto atual da lista de produtos
                var produto = produtos[i];

                //Verifiva se a localização do produto atual é armazém
                if (produto.Localizacao == ProdutoLocalizacao.Armazem)
                {
                    //Adiciona o preço total do produto atual que foi filtrado por armazém
                    precos.Add(produto.CalcularPrecoTotal());
                }
            }
            return precos;
        }
        public double ObterMediaPrecosTotais()
        {
            var somaPrecosTotais = 0.0;

            //Percorre todos os produtos
            for (int i = 0; i < produtos.Count; i++)
            {
                //Obtém o produto atual da lista de produtos
                var produto = produtos[i];

                //Adiciona o preço total do produto na variável soma de preços totais
                somaPrecosTotais += produto.CalcularPrecoTotal();
            }
            var media = somaPrecosTotais / produtos.Count;
            return media;
        }
    }
}
