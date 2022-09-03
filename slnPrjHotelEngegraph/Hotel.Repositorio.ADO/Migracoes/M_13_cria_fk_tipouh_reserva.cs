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
    public class M_13_cria_fk_tipouh_reserva : MigracaoBase
    {
        public M_13_cria_fk_tipouh_reserva()
        {
            versao = 13;
        }
        public override void Executar(SqlCommand comando)
        {
            if (comando.TableExists("Reserva"))
            {
                var sql = @"ALTER TABLE dbo.Reserva  WITH CHECK ADD FOREIGN KEY(TipoUhId)
                        REFERENCES dbo.TipoUh (Id);";

                comando.CommandText = sql;
                comando.ExecuteNonQuery();

            }
        }
    }
}
