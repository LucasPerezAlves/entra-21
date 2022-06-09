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
    }
}
