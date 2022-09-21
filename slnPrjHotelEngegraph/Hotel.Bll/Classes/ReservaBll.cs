using Hotel.Comum.Auxiliares;
using Hotel.Comum.Dto;
using Hotel.Comum.Enumerados;
using Hotel.Comum.Interfaces;
using Hotel.Comum.Modelos;
using Hotel.Comum.ViewModels;
using Hotel.Repositorio.ADO.Classes;
using System;
using System.Collections.Generic;
using System.Data;

namespace Hotel.Bll.Classes
{
    public class ReservaBll : BllBase<Reserva, IRepositorioReserva>
    {
        private readonly TipoUhBll _tipoUhBll;

        public ReservaBll()
        {
            _repositorio = new RepositorioADOReserva();
            _tipoUhBll = new TipoUhBll();
        }

        public override Reserva Persistir(Reserva obj, EnOperacao operacao)
        {
            if(operacao == EnOperacao.Insert)
            {
                var txtLocalizador = Guid.NewGuid().ToString();
                obj.Localizador = txtLocalizador.Substring(txtLocalizador.Length - 6, 6);
            }
            
            return base.Persistir(obj, operacao);
        }

        public override ObjetoDeValidacao Validar(Reserva objeto)
        {
            var resultadoValidacao = new ObjetoDeValidacao();

            if(objeto.DataCheckIn.Date >= objeto.DataCheckOut)
            {
                resultadoValidacao.Criticas.Add("Data Chek-In deve ser anterior a data de check-Out");
            }

            if (objeto.QtdeAdt > objeto.TipoUh.QtdeAdt)
            {
                resultadoValidacao.Criticas.Add("Limite de adultos excedido");
            }

            if (objeto.QtdeChd > objeto.TipoUh.QtdeChd)
            {
                resultadoValidacao.Criticas.Add("Limite de adultos excedido");
            }

            if (string.IsNullOrWhiteSpace(objeto.NomeSolicitante))
            {
                resultadoValidacao.Criticas.Add("Solicitante deve ser informado.");
            }

            if (string.IsNullOrWhiteSpace(objeto.TelefoneSolicitante))
            {
                resultadoValidacao.Criticas.Add("Telefone do solicitante deve ser informado.");
            }

            if (string.IsNullOrWhiteSpace(objeto.EMailSolicitante))
            {
                resultadoValidacao.Criticas.Add("E-mail do solicitante é requerido.");
            }

            return resultadoValidacao;
        }

        public List<TipoUh> ObterTiposUh(bool isConsulta = true)
        {
            var tabela = _tipoUhBll.List();
            
            if (isConsulta)
            {
                var row = new TipoUh()
                {
                    Id = default(Guid),
                    Descricao = Constantes.TODAS
                };

                tabela.Add(row);
            }
            
            return tabela;
        }

        public void AtualizarSituacaoReserva(Reserva reserva, EnSituacaoReserva situacao)
        {
            reserva.Situacao = situacao;
            Persistir(reserva, EnOperacao.Update);
        }

        public TipoUh GetTipoUh(Guid id)
        {
            return _tipoUhBll.GetById(id);
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
                    ValorDiaria = reserva.TipoUh?.ValorDiaria ?? 0,
                    Situacao = reserva.Situacao
                });
            }

            return resultado;
        }
    }
}
