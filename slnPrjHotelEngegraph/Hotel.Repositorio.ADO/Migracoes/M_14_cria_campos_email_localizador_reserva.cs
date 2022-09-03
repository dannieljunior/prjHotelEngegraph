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
    public class M_14_cria_campos_email_localizador_reserva : MigracaoBase
    {
        public M_14_cria_campos_email_localizador_reserva()
        {
            versao = 14;
        }
        public override void Executar(SqlCommand comando)
        {
            if (comando.TableExists("Reserva"))
            {
                var comandos = new List<string>()
                {
                    "ALTER TABLE Reserva ADD EMailSolicitante varchar(100) NOT NULL;",
                    "ALTER TABLE Reserva ADD Localizador varchar(12) NOT NULL;"
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
