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
    public class M_11_cria_campo_uh_ocupacao : MigracaoBase
    {
        public M_11_cria_campo_uh_ocupacao()
        {
            versao = 11;
        }
        public override void Executar(SqlCommand comando)
        {
            if (comando.TableExists("Ocupacao"))
            {
                var sql = "ALTER TABLE Ocupacao ADD UhId uniqueidentifier not null;";

                comando.CommandText = sql;
                comando.ExecuteNonQuery();

                sql = "ALTER TABLE Ocupacao ADD FOREIGN KEY(UhId) REFERENCES Uh(Id); ";

                comando.CommandText = sql;
                comando.ExecuteNonQuery();

            }
        }
    }
}
