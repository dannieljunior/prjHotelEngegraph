using System.Data.SqlClient;

namespace Hotel.Bll.Classes
{
    public static class ComandoSql
    {
        public static string StringDeConexao { get; set; }

        public static SqlCommand CriarComando(string pSql = "")
        {
            var conexao = new SqlConnection(StringDeConexao);
            conexao.Open();
            var comando = conexao.CreateCommand();
            comando.CommandText = pSql;
            return comando;
        }
    }
}