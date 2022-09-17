using Hotel.Comum.Enumerados;
using Hotel.Comum.Modelos;
using Hotel.Comum.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Cliente.Eventos
{
    public class ConfiguracaoEventArgs : EventArgs
    {
        private readonly Configuracao _configuracao;
        public ConfiguracaoEventArgs(Configuracao obj)
        {
            _configuracao = obj;
        }

        public Configuracao Configuracao => _configuracao;
    }
}
