using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemploWindowsForms.Exemplo01
{
    internal class EnderecoServico
    {
        private List<Endereco> enderecos;
        public EnderecoServico()
        {
            //Construtor: mais pra frente
            enderecos = new List<Endereco>();

            LerArquivo();
        }

        //Metodo adicionar recebe como parametro o objeto do endereço completo de Form (Controller)
        public void Adicionar(Endereco endereco)
        {
            enderecos.Add(endereco);

            SalvarArquivo();
        }

        public void Editar(Endereco enderecoParaAlterar)
        {
            //Percorre a lista de enderecos afim de encontrar o endereco que deve ser alterado
            for (int i = 0; i < enderecos.Count; i++)
            {
                    //Obtem o endereco da lista de enderecos
                var endereco = enderecos[i];

                //Verifica se o codigo do endereco percorrido é o mesmo que do endereco que deve ser alterado
                if(endereco.Codigo == enderecoParaAlterar.Codigo)
                {
                    //Atualiza campos do endereco encontrado
                    endereco.EnderecoCompleto =
                        enderecoParaAlterar.EnderecoCompleto;
                    endereco.Cep = enderecoParaAlterar.Cep;
                    endereco.Paciente = enderecoParaAlterar.Paciente;

                    SalvarArquivo();

                    return;
                }
            }
        }

        public void Apagar(int codigoParaApagar)
        {
            //Percorre a lista de endereços afim de encontrar o endereço que deve ser removido
            for(int i = 0; i < enderecos.Count; i++)
            {
                //Obtem o endereço percorrido
                var endereco = enderecos[i];

                if(endereco.Codigo == codigoParaApagar)
                {
                    //Remove o endereço encontrado da lista de endereços
                    enderecos.Remove(endereco);

                    SalvarArquivo();

                    return;
                }
            }
        }

        //Metodo que permite listar todos os endereços
        public List<Endereco> ObterTodos()
        {
            return enderecos;
        }

        public Endereco ObterPorCodigo(int codigo)
        {
            //Percorre a lista de endereços afim de encontrar o endereço com o código desejado
            for(var i = 0; i < enderecos.Count; i++)
            {
                //Obtém o endereço percorrido
                var endereco = enderecos[i];

                if(endereco.Codigo == codigo)
                {
                    return endereco;
                }
            }
            //Retorna null pois não encontrou o endereço com o código desejado
            return null;
        }

        public void SalvarArquivo()
        {
            var enderecosEmJson = JsonConvert.SerializeObject(enderecos);
            File.WriteAllText("enderecos.json", enderecosEmJson);

        }

        public void LerArquivo()
        {
            //Verifica se o endereco não existe
            if (File.Exists("enderecos.json") == false)
                return;

            //Ler o arquivo JSON e converto para uma lista de objetos de endereços
            var enderecosEmJson = File.ReadAllText("enderecos.json");
            enderecos = JsonConvert.DeserializeObject<List<Endereco>>(enderecosEmJson);
        }
    }
}
