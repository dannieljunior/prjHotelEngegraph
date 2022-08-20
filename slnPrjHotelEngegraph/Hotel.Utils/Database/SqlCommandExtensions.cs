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
    }
}
