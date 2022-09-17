using Hotel.Repositorio.ADO.Classes;
using Hotel.Utils.Database;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Hotel.Repositorio.ADO.Migracoes
{
    public class M_18_CriaCampoTipoParametro : MigracaoBase
    {
        public M_18_CriaCampoTipoParametro()
        {
            versao = 18;
        }
        public override void Executar(SqlCommand comando)
        {
            if (comando.TableExists("Configuracao"))
            {
                var sql = @"ALTER TABLE Configuracao ADD Tipo smallint default 0";

                comando.CommandText = sql;
                comando.ExecuteNonQuery();
            }
        }
    }
}
