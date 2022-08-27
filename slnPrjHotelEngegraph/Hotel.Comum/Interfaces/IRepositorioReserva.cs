using Hotel.Comum.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Comum.Interfaces
{
    public interface IRepositorioReserva: IRepositorio<Reserva>
    {
        List<Reserva> GetReservations(DateTime dataCheckIn, DateTime dataCheckOut, string tipoUh);
    }
}
