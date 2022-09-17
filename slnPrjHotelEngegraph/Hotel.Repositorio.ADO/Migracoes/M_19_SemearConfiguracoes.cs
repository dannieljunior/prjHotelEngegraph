using Hotel.Comum.Auxiliares;
using Hotel.Comum.Enumerados;
using Hotel.Comum.Modelos;
using Hotel.Repositorio.ADO.Classes;
using Hotel.Utils.Database;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Hotel.Repositorio.ADO.Migracoes
{
    public class M_19_SemearConfiguracoes : MigracaoBase
    {
        public M_19_SemearConfiguracoes()
        {
            versao = 19;
        }
        public override void Executar(SqlCommand comando)
        {
            if (comando.TableExists("Configuracao"))
            {
                var configuracoes = new List<Configuracao>()
                {
                    new Configuracao()
                    {
                        Codigo = 1001, Descricao = "Idade Máxima Criança", Tipo = EnTipoConfiguracao.Inteiro, Valor = "12"
                    },
                    new Configuracao()
                    {
                        Codigo = 1002, Descricao = "Limite de tentativas de login", Tipo = EnTipoConfiguracao.Inteiro, Valor = "6"
                    },
                    new Configuracao()
                    {
                        Codigo = 1003, Descricao = "Dias para expiração de senha de usuário", Tipo = EnTipoConfiguracao.Inteiro, Valor = "90"
                    },
                    new Configuracao()
                    {
                        Codigo = 1004, Descricao = "Valor minimo de diária", Tipo = EnTipoConfiguracao.Numerico, Valor = "0.00"
                    },
                    new Configuracao()
                    {
                        Codigo = 1005, Descricao = "Validar quantidade de crianças", Tipo = EnTipoConfiguracao.Booleano, Valor = Constantes.TRUE
                    }
                };

                var repositorio = new RepositorioADOConfiguracao();

                configuracoes.ForEach(configuracao =>
                {
                    repositorio.Insert(configuracao);
                });


            }
        }
    }
}
