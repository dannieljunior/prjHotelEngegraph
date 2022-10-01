using Hotel.Comum.Modelos;
using Hotel.Comum.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Comum.Interfaces
{
    public interface IRepositorioOcupacao: IRepositorio<Ocupacao>
    {
        List<MapaOcupacaoViewModel> ObterMapaDeOcupacao();
    }
}
