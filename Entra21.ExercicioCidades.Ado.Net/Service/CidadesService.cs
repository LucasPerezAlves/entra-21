using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entra21.ExercicioCidades.Ado.Net.DataBase;
using Entra21.ExercicioCidades.Ado.Net.Models;
using System.Data;

namespace Entra21.ExercicioCidades.Ado.Net.Service
{
    internal class CidadesService
    {
        public void Apagar(int id)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();
            comando.CommandText = "DELETE FROM cidades WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);
            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }

        public void Cadastrar(Cidades cidade)
        {
            var conexao = new Conexao().Conectar();

            SqlCommand comando = conexao.CreateCommand();

            comando.CommandText = "INSERT INTO cidades (id_unidade_federativa, nome, quantidade_habitantes, data_hora_fundacao, pib) VALUES (@ID_UNIDADE_FEDERATIVA, @NOME, @QUANTIDADE_HABITANTES, @DATA_HORA_FUNDACAO, @PIB);";

            comando.Parameters.AddWithValue("@ID_UNIDADE_FEDERATIVA", cidade.UnidadeFederativa.Id);
            comando.Parameters.AddWithValue("@NOME", cidade.Nome);
            comando.Parameters.AddWithValue("@QUANTIDADE_HABITANTES", cidade.Quantidade_Habitantes);
            comando.Parameters.AddWithValue("@DATA_HORA_FUNDACAO", cidade.Data_Hora_Fundacao);
            comando.Parameters.AddWithValue("PIB", cidade.Pib);

            comando.ExecuteNonQuery();

            conexao.Close();
        }

        public void Editar(Cidades cidade)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText =
                "UPDATE cidades SET id_unidade_federativa = @ID_UNIDADE_FEDERATIVA, nome = @NOME, quantidade_habitantes = @QUANTIDADE_HABITANTES, data_hora_fundacao = @DATA_HORA_FUNDACAO, pib = @PIB";

                comando.Parameters.AddWithValue("@ID_UNIDADE_FEDERATIVA", cidade.UnidadeFederativa.Id);
            comando.Parameters.AddWithValue("@NOME", cidade.Nome);
            comando.Parameters.AddWithValue("@QUANTIDADE_HABITANTES", cidade.Quantidade_Habitantes);
            comando.Parameters.AddWithValue("@DATA_HORA_FUNDACAO", cidade.Data_Hora_Fundacao);
            comando.Parameters.AddWithValue("@PIB", cidade.Pib);

            comando.ExecuteNonQuery();
            comando.Connection.Close();

        }

        public Cidades ObterPorId(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = "SELECT id, nome, quantidade_habitantes, data_hora_fundacao, pib FROM cidades WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            var dataTable = new DataTable();
            dataTable.Load(comando.ExecuteReader());
            if (dataTable.Rows.Count == 0)
                return null;

            var registro = dataTable.Rows[0];
            var cidades = new Cidades();
            cidades.Id = Convert.ToInt32(registro["id"]);
            cidades.Quantidade_Habitantes = registro["quantidade_habitantes"]

            cidades.UnidadeFederativa = new UnidadesFederativas();
            cidades.UnidadeFederativa.Id = Convert.ToInt32(registro["id_unidade_federativa"]);
            cidades.Nome = registro["nome"].ToString();
           
            
        }

    }
}
