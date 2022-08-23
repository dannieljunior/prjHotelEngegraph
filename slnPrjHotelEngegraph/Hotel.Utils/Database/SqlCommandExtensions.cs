using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Utils.Database
{
    public static class SqlCommandExtensions
    {
        public static bool TableExists(this SqlCommand comando, string tableName)
        {
            var table = tableName.ToUpper();

            comando.CommandText = $@"SELECT 
                                      COUNT(*) AS cont
                                    FROM sys.tables
                                    WHERE upper(name) = '{table}';";
            
            var resultado = (int)comando.ExecuteScalar();

            return resultado > 0;
        }

        public static void FreeAndNil(this SqlCommand comando)
        {
            if (comando.Connection.State == System.Data.ConnectionState.Open)
                comando.Connection.Close();

            comando.Connection.Dispose();
            comando.Dispose();
        }
    }
}
