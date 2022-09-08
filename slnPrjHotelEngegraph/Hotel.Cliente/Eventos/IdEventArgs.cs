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
    public class IdEventArgs : EventArgs
    {
        private readonly Guid _id;
        public IdEventArgs(Guid obj)
        {
            _id = obj;
        }

        public Guid Id => _id;
    }
}
