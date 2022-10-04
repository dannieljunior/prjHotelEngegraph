using Hotel.Comum.Auxiliares;
using Hotel.Comum.Enumerados;
using Hotel.Comum.Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Repositorio.EF
{
    public class MigrationsConfiguration: DbMigrationsConfiguration<HotelDbContext>
    {
        public MigrationsConfiguration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(HotelDbContext context)
        {
            if (!context.Usuarios.Any())
            {
                var usuario = new Usuario()
                {
                    Id = Guid.NewGuid(),
                    Ativo = true,
                    DataCriacao = DateTime.Now,
                    DataExpiracao = DateTime.Now.AddDays(90),
                    EMail = "admin@hotel.com.br",
                    Login = "sa",
                    Senha = "987654",
                    Tentativas = 0
                };

                context.Usuarios.Add(usuario);

                context.SaveChanges();
            }

            if (!context.Configuracoes.Any())
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

                configuracoes.ForEach(configuracao =>
                {
                    configuracao.Id = Guid.NewGuid();
                    configuracao.DataCriacao = DateTime.Now;
                    context.Configuracoes.Add(configuracao);
                    context.SaveChanges();
                });
            }
        }
    }
}
