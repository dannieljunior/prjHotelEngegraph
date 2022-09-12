using Hotel.Repositorio.ADO.Classes;
using Hotel.Utils.Database;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Hotel.Repositorio.ADO.Migracoes
{
    public class M_16_CriaTabelaLancamentos : MigracaoBase
    {
        public M_16_CriaTabelaLancamentos()
        {
            versao = 16;
        }
        public override void Executar(SqlCommand comando)
        {
            if (!comando.TableExists("Lancamentos"))
            {
                var comandos = new List<string>()
                {
                    @"CREATE TABLE Lancamentos(
	                        Id uniqueidentifier NOT NULL primary key,
	                        Valor numeric(14, 2) NOT NULL default 0.00,
	                        TipoPagtoId uniqueidentifier,
                            CheckOutId uniqueidentifier,
                            Conta smallint,
                            Data datetime NOT NULL,
                            DataCriacao datetime NOT NULL,
	                        DataModificacao datetime NULL
                        )",
                    @"ALTER TABLE Lancamentos WITH CHECK ADD FOREIGN KEY(TipoPagtoId)
                        REFERENCES TipoPagto (Id); ",
                    @"ALTER TABLE Lancamentos WITH CHECK ADD FOREIGN KEY(CheckOutId)
                        REFERENCES CheckOut (Id); "
            };

            comandos.ForEach(sql =>
            {
                comando.CommandText = sql;
                comando.ExecuteNonQuery();
            });
                    
                    

                
            }
        }
    }
}
