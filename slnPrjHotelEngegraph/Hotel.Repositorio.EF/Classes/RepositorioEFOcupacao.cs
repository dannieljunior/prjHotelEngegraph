using Hotel.Comum.Enumerados;
using Hotel.Comum.Interfaces;
using Hotel.Comum.Modelos;
using Hotel.Comum.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Repositorio.EF.Classes
{
    public class RepositorioEFOcupacao : RepositorioBase<Ocupacao>, IRepositorioOcupacao
    {
        public override List<Ocupacao> List()
        {
            return dbset.Include("Uh").Include("Reserva").ToList();
        }
        public List<MapaOcupacaoViewModel> ObterMapaDeOcupacao()
        {
            return dbset.Include("Uh").Include("Reserva").OrderBy(x => x.Uh.Numero).Select(
                y => new MapaOcupacaoViewModel
                {
                    Id = y.Uh.Id,
                    Numero = y.Uh.Numero,
                    Bloco = y.Uh.Bloco,
                    Nivel = y.Uh.Nivel,
                    DataCheckIn = y.DataCheckIn,
                    DataCheckOut = y.Reserva.DataCheckOut,
                    OcupacaoId = y.Id,
                    Situacao = (EnSituacaoUh)y.Situacao
                }).ToList();
        }
    }
}
