using Hotel.Comum.Interfaces;
using Hotel.Comum.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Repositorio.EF.Classes
{
    public class RepositorioEFReserva : RepositorioBase<Reserva>, IRepositorioReserva
    {
        public override List<Reserva> List()
        {
            return dbset.Include("TipoUh").ToList();
        }

        public List<Reserva> GetReservations(DateTime dataCheckIn, DateTime dataCheckOut, string tipoUh)
        {
            var query = dbset.Include("TipoUh").Where(r => r.DataCheckIn >= dataCheckIn && 
                                                      r.DataCheckOut <= dataCheckOut);

            var idTipoUh = new Guid(tipoUh);

            if (!string.IsNullOrWhiteSpace(tipoUh) && new Guid(tipoUh) != default(Guid))
            {
                query = query.Where(r => r.TipoUhId == idTipoUh);
            }

            return query.ToList();
        }
    }
}
