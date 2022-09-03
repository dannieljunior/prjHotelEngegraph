using Hotel.Comum.Dto;
using Hotel.Comum.Enumerados;
using Hotel.Comum.Interfaces;
using Hotel.Comum.Modelos;
using Hotel.Comum.ViewModels;
using Hotel.Repositorio.ADO.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Hotel.Bll.Classes
{
    public class OcupacaoBll : BllBase<Ocupacao, IRepositorioOcupacao>
    {
        private readonly HospedeBll _hospedeBll;
        private readonly ReservaBll _reservaBll;
        private readonly UhBll _uhBll;
        private readonly HospedeOcupacaoBll _hospedeOcupacalBll;

        public List<HospedeViewModel> Hospedes { get; set; }

        public OcupacaoBll()
        {
            _repositorio = new RepositorioADOOcupacao();
            _reservaBll = new ReservaBll();
            _hospedeBll = new HospedeBll();
            _uhBll = new UhBll();
            _hospedeOcupacalBll = new HospedeOcupacaoBll();
        }

        public Uh ObterUhPorId(Guid id)
        {
            return _uhBll.GetById(id);
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

        public override Ocupacao Persistir(Ocupacao obj, EnOperacao operacao)
        {
            obj.Situacao = EnSituacaoOcupacao.Ocupada;
            var objetoRetorno = base.Persistir(obj, operacao);
            _reservaBll.AtualizarSituacaoReserva(obj.Reserva, EnSituacaoReserva.Concluida);
            _uhBll.AtualizarSituacaoUh(obj.Uh, EnSituacaoUh.Ocupada);
            var hospedesDaOcupacao = ObterHospedes();

            hospedesDaOcupacao.ForEach(h =>
            {
                _hospedeBll.Persistir(h, EnOperacao.Insert);
                _hospedeOcupacalBll.Persistir(new HospedeOcupacao()
                {
                    Hospede = h,
                    Ocupacao = objetoRetorno
                }, EnOperacao.Insert);
            });

            return objetoRetorno;
        }

        private List<Hospede> ObterHospedes()
        {
            List<Hospede> resultado = new List<Hospede>();

            Hospedes.ForEach(h =>
            {
                resultado.Add(new Hospede()
                {
                    Nome = h.Nome,
                    SobreNome = h.SobreNome,
                    DataNascimento = h.DataNascimento,
                    Endereco = h.Endereco,
                    Genero = h.Genero,
                    IsEstrangeiro = h.IsEstrangeiro,
                    NumeroDocumento = h.NumeroDocumento,
                    Telefone = h.Telefone
                });
            });

            return resultado;
        }

        public override ObjetoDeValidacao Validar(Ocupacao objeto)
        {
            var resultadoValidacao = new ObjetoDeValidacao();

            if(objeto.DataCheckIn.Date != objeto.Reserva.DataCheckIn.Date)
            {
                resultadoValidacao.Criticas.Add("Não é possível fazer check-In em data diferente da reservada");
            }

            var qtdeAdt = Hospedes.Count(x => x.ClassiFicacaoHospede.Equals("ADULTO"));
            var qtdeChd = Hospedes.Count(x => x.ClassiFicacaoHospede.Equals("CRIANCA"));

            if(qtdeAdt > objeto.Uh.TipoUh.QtdeAdt)
            {
                resultadoValidacao.Criticas.Add("A quantidade de adultos para a UH selecionada ultrapassa sua capacidade.");
            }

            if (qtdeChd > objeto.Uh.TipoUh.QtdeChd)
            {
                resultadoValidacao.Criticas.Add("A quantidade de crianças para a UH selecionada ultrapassa sua capacidade.");
            }

            return resultadoValidacao;
        }
    }
}
