using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entra21.ExercicioCidades.Ado.Net.DataBase;
using Entra21.ExercicioCidades.Ado.Net.Models;

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

            comando.Parameters.AddWithValue("@ID_UNIDADE_FEDERATIVA", cidade.UnidadeFederativa.Id,
                "@NOME", cidade.Nome,
                "@quant"
        }
    }
}
