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
    public class M_12_cria_campos_solictante_reserva : MigracaoBase
    {
        public M_12_cria_campos_solictante_reserva()
        {
            versao = 12;
        }
        public override void Executar(SqlCommand comando)
        {
            if (comando.TableExists("Reserva"))
            {
                var sql = "ALTER TABLE Reserva ADD NomeSolicitante varchar(40) not null;";

                comando.CommandText = sql;
                comando.ExecuteNonQuery();

                sql = "ALTER TABLE Reserva ADD TelefoneSolicitante varchar(15) not null;";

                comando.CommandText = sql;
                comando.ExecuteNonQuery();

            }
        }
    }
}
