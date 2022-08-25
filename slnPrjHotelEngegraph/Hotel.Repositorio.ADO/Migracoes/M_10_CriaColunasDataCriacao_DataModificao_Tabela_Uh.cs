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
    public class M_10_CriaColunasDataCriacao_DataModificao_Tabela_Uh : MigracaoBase
    {
        public M_10_CriaColunasDataCriacao_DataModificao_Tabela_Uh()
        {
            versao = 10;
        }
        public override void Executar(SqlCommand comando)
        {
            if (comando.TableExists("Uh"))
            {
                var sql = @"ALTER TABLE Uh ADD DataCriacao DateTime NOT NULL";

                comando.CommandText = sql;
                comando.ExecuteNonQuery();

                sql = @"ALTER TABLE Uh ADD DataModificacao DateTime";

                comando.CommandText = sql;
                comando.ExecuteNonQuery();
            }
        }
    }
}
