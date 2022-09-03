using Hotel.Comum.Dto;
using Hotel.Comum.Interfaces;
using Hotel.Comum.Modelos;
using Hotel.Comum.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;

namespace Hotel.Bll.Classes
{
    public class OcupacaoBll : BllBase<Ocupacao, IRepositorioOcupacao>
    {
        private readonly HospedeBll _hospedeBll;
        private readonly ReservaBll _reservaBll;
        private readonly UhBll _uhBll;

        public OcupacaoBll()
        {
            _reservaBll = new ReservaBll();
            _hospedeBll = new HospedeBll();
            _uhBll = new UhBll();
        }

        public Reserva ObterReservaPorId(Guid id)
        {
            return _reservaBll.GetById(id);
        }

        public ReservaViewModel ObterDadosDaReserva(Guid id)
        {
            var reserva = _reservaBll.GetById(id);

            return new ReservaViewModel()
            {
                Id = reserva.Id,
                DataCheckIn = reserva.DataCheckIn,
                DataCheckOut = reserva.DataCheckOut,
                Solicitante = $"{reserva.NomeSolicitante} ({reserva.TelefoneSolicitante})",
                TipoUhDescricao = reserva.TipoUh?.Descricao,
                QtdeAdt = reserva.QtdeAdt,
                QtdeChd = reserva.QtdeChd,
                ValorDiaria = reserva.TipoUh?.ValorDiaria ?? 0,
                Situacao = reserva.Situacao
            };
        }

        public List<Uh> ObterUhs(Guid id)
        {
            return _uhBll.ObterUhsPorTipo(id);
        }

        public override ObjetoDeValidacao Validar(Ocupacao objeto)
        {
            throw new NotImplementedException();
        }

        //metodo que receberá uma lista de hospedeViewModel

        //validar se a quantidade de crianças e adultos bate com o da configuração do tipo UH

        //Validar se a data de checkin bate com a da reserva. Caso contrário, deve informar que é um late checkin.

    }
}
