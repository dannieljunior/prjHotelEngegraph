using Hotel.Comum.Dto;
using Hotel.Comum.Interfaces;
using Hotel.Comum.Modelos;
using Hotel.Comum.ViewModels;
using Hotel.Repositorio.ADO.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Bll.Classes
{
    public class ReservaBll : BllBase<Reserva, RepositorioADOReserva>
    {
        public ReservaBll()
        {
            _repositorio = new RepositorioADOReserva();
        }

        public override ObjetoDeValidacao Validar(Reserva objeto)
        {
            throw new NotImplementedException();
        }

        public List<ReservaViewModel> ObterReservas(DateTime dataCheckIn, DateTime dataCheckOut, string tipoUh)
        {
            var listaReservas = _repositorio.GetReservations(dataCheckIn, dataCheckOut, tipoUh);

            var resultado = new List<ReservaViewModel>();

            foreach(var reserva in listaReservas)
            {
                resultado.Add(new ReservaViewModel()
                {
                    Id = reserva.Id,
                    DataCheckIn = reserva.DataCheckIn,
                    DataCheckOut = reserva.DataCheckOut,
                    Solicitante = $"{reserva.NomeSolicitante} ({reserva.TelefoneSolicitante})",
                    TipoUhDescricao = reserva.TipoUh?.Descricao,
                    QtdeAdt = reserva.QtdeAdt,
                    QtdeChd = reserva.QtdeChd,
                    ValorDiaria = reserva.TipoUh?.ValorDiaria ?? 0
                });
            }

            return resultado;
        }
    }
}
