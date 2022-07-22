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
    internal class CidadesService : ICidadeService
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
            comando.Parameters.AddWithValue("@QUANTIDADE_HABITANTES", cidade.QuantidadeHabitantes);
            comando.Parameters.AddWithValue("@DATA_HORA_FUNDACAO", cidade.DataHoraFundacao);
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
            comando.Parameters.AddWithValue("@QUANTIDADE_HABITANTES", cidade.QuantidadeHabitantes);
            comando.Parameters.AddWithValue("@DATA_HORA_FUNDACAO", cidade.DataHoraFundacao);
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

            cidades.UnidadeFederativa = new UnidadesFederativas();
            cidades.UnidadeFederativa.Id = Convert.ToInt32(registro["id_unidade_federativa"]);
            cidades.Nome = registro["nome"].ToString();

            conexao.Close();

            return cidades;
            
        }

        public List<Cidades> ObterTodos(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"SELECT";

            comando.CommandText = @"SELECT
id, id_unidade_federativa, nome, quantidade_habitantes, data_hora_fundacao, pib
FROM cidades WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", id);
            var dataTable = new DataTable();

            dataTable.Load(comando.ExecuteReader());

            if (dataTable.Rows.Count == 0)
                return null;

            var registro = dataTable.Rows[0];
            var cidade = new Cidades();
            cidade.Id = Convert.ToInt32(registro["id"]);

            cidade.UnidadeFederativa = new UnidadesFederativas();
            cidade.UnidadeFederativa.Id = Convert.ToInt32(registro["id_unidade_federativa"]);

            cidade.Nome = registro["nome"].ToString();
            cidade.QuantidadeHabitantes = Convert.ToInt32(registro["quantidade_habitantes"]);
            cidade.DataHoraFundacao = Convert.ToDateTime(registro["data_hora_fundacao"]);
            //Acho que eta faltando coisa

            comando.Connection.Close();

            return cidade;
        }

    }
}
