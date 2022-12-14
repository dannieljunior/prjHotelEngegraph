using Hotel.Comum.Enumerados;
using Hotel.Comum.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Comum.Interfaces
{
    public interface IRepositorioUh: IRepositorio<Uh>
    {
        List<Uh> ObterUhsPorTipo(Guid tipoUhId, EnSituacaoUh? situacao);
    }
}
