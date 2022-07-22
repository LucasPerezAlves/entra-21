using Entra21.ExercicioCidades.Ado.Net.DataBase;
using Entra21.ExercicioCidades.Ado.Net.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExercicioCidades.Ado.Net.Service
{
    internal class UnidadeFederativaService : IUnidadeFederativaService
    {
        public void Apagar(int id)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = "DELETE FROM unidades_federativas WHERE id = @ID";
            comando.Parameters.AddWithValue("ID", id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Cadastrar(UnidadesFederativas unidadeFederativa)
        {
            var conexao = new Conexao().Conectar();

            SqlCommand comando = conexao.CreateCommand();

            comando.CommandText = "INSERT INTO unidades_federativas (mome, sigla) VALUES (@NOME, @SIGLA)";
            comando.Parameters.AddWithValue("@NOME", unidadeFederativa.Nome);
            comando.Parameters.AddWithValue("@SIGLA", unidadeFederativa.Sigla);

            comando.ExecuteNonQuery();

            conexao.Close();
        }
        //testar Selects
        public void Editar(UnidadesFederativas unidadeFederativa)
        {
            var conexao = new Conexao().Conectar();

            //Testar os selects
            var comando = conexao.CreateCommand();
            comando.CommandText =
                "UPDATE unidades_federativas SET nome = @NOME, sigla = @SIGLA WHERE @ID";
            comando.Parameters.AddWithValue("@NOME", unidadeFederativa.Nome);
            comando.Parameters.AddWithValue("@SIGLA", unidadeFederativa.Sigla);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public UnidadesFederativas ObterPorId(int id)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();
            comando.CommandText =
                "SELECT id, nome, sigla FROM unidades_federativas WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            var tabelaEmMemoria = new DataTable();

            tabelaEmMemoria.Load(comando.ExecuteReader());

            if (tabelaEmMemoria.Rows.Count == 0)
                return null;

            var primeiroRegistro = tabelaEmMemoria.Rows[0];

            var unidadeFederativa = new UnidadesFederativas();
            unidadeFederativa.Id = Convert.ToInt32(primeiroRegistro["id"]);
            unidadeFederativa.Nome = primeiroRegistro["nome"].ToString();
            unidadeFederativa.Sigla = primeiroRegistro["sigla"].ToString();

            comando.Connection.Close();

            return unidadeFederativa;
        }

        public List<UnidadesFederativas> ObterTodos()
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = "SELECT id, nome, sigla FROM unidades_federativas";

            var tabelaEmMemoria = new DataTable();

            tabelaEmMemoria.Load(comando.ExecuteReader());

            var unidadesFederativas = new List<UnidadesFederativas>();

            for(int i = 0; i < tabelaEmMemoria.Rows.Count;)
            {
                var linha = tabelaEmMemoria.Rows[i];

                var unidadeFederativa = new UnidadesFederativas();
                unidadeFederativa.Id = Convert.ToInt32(linha["Id"]);
                unidadeFederativa.Nome = linha["nome"].ToString();

                unidadesFederativas.Add(unidadeFederativa);
            }
            comando.Connection.Close();

            return unidadesFederativas;
        }
    }
}
