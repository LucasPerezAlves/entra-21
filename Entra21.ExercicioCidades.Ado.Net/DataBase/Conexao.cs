using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entra21.ExercicioCidades.Ado.Net.DataBase
{
    public class Conexao
    {
        public SqlConnection Conectar()
        {
            SqlConnection conexao = new SqlConnection();

            var connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\1\source\Repos\LucasPerezAlves\entra-21\Entra21.ExercicioCidades.Ado.Net\BancoDadosCidades.mdf;Integrated Security=True;Connect Timeout=30";

            conexao.ConnectionString = connectionString;

            conexao.Open();

            return conexao;
        }
    }
}
