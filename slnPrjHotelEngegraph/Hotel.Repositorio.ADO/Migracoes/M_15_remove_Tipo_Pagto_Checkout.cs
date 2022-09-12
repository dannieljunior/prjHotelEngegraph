using Hotel.Repositorio.ADO.Classes;
using Hotel.Utils.Database;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Repositorio.ADO.Migracoes
{
    public class M_15_remove_Tipo_Pagto_Checkout : MigracaoBase
    {
        public M_15_remove_Tipo_Pagto_Checkout()
        {
            versao = 15;
        }
        public override void Executar(SqlCommand comando)
        {
            if (comando.TableExists("Checkout"))
            {
                var comandos = new List<string>()
                {
                    "ALTER TABLE Checkout DROp CONSTRAINT FK__CheckOut__TipoPa__45F365D3;",
                    "ALTER TABLE Checkout DROP COLUMN TipoPagtoId"
                };

                foreach(var sql in comandos)
                {
                    comando.CommandText = sql;
                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}
