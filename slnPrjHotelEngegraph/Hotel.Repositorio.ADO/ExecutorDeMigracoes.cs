using Hotel.Repositorio.ADO;
using Hotel.Repositorio.ADO.Classes;
using Hotel.Utils.Database;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Hotel.Bll.Classes
{
    public class ExecutorDeMigracoes
    {
        readonly string _sqlTabelaVersao = @"CREATE TABLE VERSAO(
                                                    Versao int primary key,
                                                    DataExecucao DateTime not null default getdate()
                                                )";

        readonly SqlCommand _comando;

        public ExecutorDeMigracoes()
        {
            var conexao = Conexao.Conectar();
            _comando = conexao.CreateCommand();
            var transacao = conexao.BeginTransaction();

            try
            {
                _comando.Transaction = transacao;
                GarantirEstrutura();
                ExecutarMigracoes();
                transacao.Commit();
            }
            catch (Exception ex)
            {
                transacao.Rollback();
            }
            finally
            {
                _comando.FreeAndNil();
            }
            
        }

        private void GarantirEstrutura()
        {
            if (_comando.TableExists("versao"))
            {
                return;
            }
            _comando.CommandText = _sqlTabelaVersao;
            _comando.ExecuteNonQuery();
        }

        private void ExecutarMigracoes()
        {
            var ultimaVersao = ObterUltimaVersao();

            var migrouBanco = false;

            List<MigracaoBase> migracoes = typeof(MigracaoBase)
                .Assembly.GetTypes()
                .Where(t => t.IsSubclassOf(typeof(MigracaoBase)) && !t.IsAbstract)
                .Select(t => (MigracaoBase)Activator.CreateInstance(t)).ToList();

            foreach (var migracao in migracoes.OrderBy(x => x.Versao))
            {
                if (migracao.Versao > ultimaVersao)
                {
                    migracao.Executar(_comando);
                    ultimaVersao = migracao.Versao;
                    migrouBanco = true;
                }
            }

            if(migrouBanco)
                AtualizaVersao(ultimaVersao);
        }

        private  int ObterUltimaVersao()
        {
            var sql = "SELECT isnull(MAX(versao), 0) FROM VERSAO";
            _comando.CommandText = sql;
            return (int)_comando.ExecuteScalar();
        }

        private void AtualizaVersao(int versao)
        {
            var sql = $"INSERT INTO VERSAO (VERSAO) VALUES ({versao})";
            _comando.CommandText = sql;
            _comando.ExecuteNonQuery();
        }
    }
}
