using Hotel.Comum.Interfaces;
using Hotel.Comum.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Repositorio.EF.Classes
{
    public class RepositorioEFTipoPagto: RepositorioBase<TipoPagto>, IRepositorioTipoPagto
    {
        public RepositorioEFTipoPagto(): base()
        {
            dbset = context.TiposPgto;
        }
    }
}
