using Hotel.Comum.Interfaces;
using Hotel.Comum.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Repositorio.EF.Classes
{
    public class RepositorioEFConfiguracao : RepositorioBase<Configuracao>, IRepositorioConfiguracao
    {
        public RepositorioEFConfiguracao()
        {
            dbset = context.Configuracoes;
        }
        public string ObterConfiguracaoPeloCodigo(int codigo)
        {
            var teste =  dbset.FirstOrDefault(x => x.Codigo == codigo)?.Valor;
            return teste;
        }
    }
}
