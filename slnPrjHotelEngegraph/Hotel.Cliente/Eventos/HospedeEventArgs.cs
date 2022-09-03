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
    public class HospedeEventArgs : EventArgs
    {
        private readonly HospedeViewModel _hospede;
        private readonly EnOperacao _operacao;
        public HospedeEventArgs(HospedeViewModel obj, EnOperacao operacao)
        {
            _hospede = obj;
            _operacao = operacao;
        }

        public HospedeViewModel Hospede => _hospede;
        public EnOperacao Operacao => _operacao;
    }
}
