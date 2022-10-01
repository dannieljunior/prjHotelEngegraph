using Hotel.Bll.IOC;
using Hotel.Comum.Dto;
using Hotel.Comum.Enumerados;
using Hotel.Comum.Interfaces;
using Hotel.Comum.IOC;
using Hotel.Comum.Modelos;
using Hotel.Repositorio.ADO.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Bll.Classes
{
    public class CheckOutBll : BllBase<CheckOut, IRepositorioCheckOut>
    {
        private readonly OcupacaoBll _ocupacaoBll;
        private readonly HospedeOcupacaoBll _hospedeOcupacaoBll;
        private readonly UhBll _uhBll;
        private readonly TipoPagtoBll _tipoPgtoBll;
        private readonly LancamentosBll _lancamentosBll;

        public CheckOutBll()
        {
            _repositorio = Kernel.Get<IRepositorioCheckOut>(); 
            _ocupacaoBll = new OcupacaoBll();
            _hospedeOcupacaoBll = new HospedeOcupacaoBll();
            _uhBll = new UhBll();
            _tipoPgtoBll = new TipoPagtoBll();
            _lancamentosBll = new LancamentosBll();
        }
        public override ObjetoDeValidacao Validar(CheckOut objeto)
        {
            var resultadoValidacao = new ObjetoDeValidacao();

            if(objeto.DataCheckOut != DateTime.Now)
            {
                resultadoValidacao.Criticas.Add("Data do Check-Out deve ser a data atual");
            }

            return resultadoValidacao;
        }

        public override CheckOut Persistir(CheckOut obj, EnOperacao operacao)
        {
            var objetoDeRetorno =  base.Persistir(obj, operacao);

            obj.Lancamentos.ForEach(lancamento =>
            {
                lancamento.CheckOut = objetoDeRetorno;
                _lancamentosBll.Persistir(lancamento, EnOperacao.Insert);
            });

            var uh = obj.Ocupacao.Uh;

            _uhBll.AtualizarSituacaoUh(uh, EnSituacaoUh.Livre);
            var ocupacao = obj.Ocupacao;

            _ocupacaoBll.AtualizarSituacaoOcupacao(ocupacao, EnSituacaoOcupacao.Inativa);

            return objetoDeRetorno;
        }

        public List<TipoPagto> ObterFormasDePagamento()
        {
            return _tipoPgtoBll.List();
        }

        public TipoPagto ObterFormaDePagamentoById(Guid id)
        {
            return _tipoPgtoBll.GetById(id);
        }

        public List<Hospede> ObterHospedes(Guid id)
        {
            var hospedes = _hospedeOcupacaoBll.ObterHospedesPorOcupacao(id);

            return hospedes.Select(x => new Hospede()
            {
                Id = x.Hospede.Id,
                Nome = x.Hospede.Nome,
                SobreNome = x.Hospede.SobreNome,
                Genero = x.Hospede.Genero,
                DataCriacao = x.Hospede.DataCriacao,
                DataModificacao = x.Hospede.DataModificacao,
                DataNascimento = x.Hospede.DataNascimento,
                IsEstrangeiro = x.Hospede.IsEstrangeiro,
                Endereco = x.Hospede.Endereco,
                NumeroDocumento = x.Hospede.NumeroDocumento,
                Telefone = x.Hospede.Telefone
            }).ToList();
        }

        public Ocupacao GetOcupacaoById(Guid id)
        {
            return _ocupacaoBll.GetById(id);
        }
    }
}
