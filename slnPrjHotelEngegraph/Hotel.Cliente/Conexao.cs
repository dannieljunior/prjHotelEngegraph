using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Cliente
{
    class Conexao
    {
        static SqlConnection _conexao;

        public static SqlConnection Conectar()
        {
            try
            {
                if (_conexao == null)
                    _conexao = new SqlConnection(ObterStringDeConexao());

                if (_conexao.State != ConnectionState.Open)
                    _conexao.Open();

                return _conexao;

                

            }
            catch
            {
                throw new Exception("Ocorreu um erro ao tentar conectar no banco de dados.");
            }
        }

        private static string ObterStringDeConexao()
        {
            var resultado = ConfigurationManager.AppSettings["StringDeConexao"];
            return resultado;
        }

        public static void Close()
        {
            if(_conexao.State != ConnectionState.Closed)
            {
                _conexao.Close();
            }
        }
    }
}
