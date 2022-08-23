using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Repositorio.ADO
{
    public static class Conexao
    {
        public static string ConnectionString { get; set; }

        public static SqlConnection Conectar()
        {
            var conexao =  new SqlConnection(ConnectionString);
            conexao.Open();
            return conexao;
        }
    }
}
