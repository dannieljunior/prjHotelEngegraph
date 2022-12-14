using Hotel.Bll.IOC;
using Hotel.Comum.Auxiliares;
using Hotel.Comum.Dto;
using Hotel.Comum.Enumerados;
using Hotel.Comum.Interfaces;
using Hotel.Comum.IOC;
using Hotel.Comum.Modelos;
using Hotel.Repositorio.ADO.Classes;
using System;
using System.Collections.Generic;
using System.Data;

namespace Hotel.Bll.Classes
{
    public class UhBll : BllBase<Uh, IRepositorioUh>
    {
        protected readonly TipoUhBll _tipoUhBll;
        public UhBll()
        {
            _repositorio = Kernel.Get<IRepositorioUh>();
            _tipoUhBll = new TipoUhBll();
        }

        public List<TipoUh> ObterTiposUh()
        {
            return _tipoUhBll.List();
        }

        public TipoUh GetTipoUh(Guid id)
        {
            return _tipoUhBll.GetById(id);
        }

        public List<Uh> ObterUhsPorTipo(Guid id, EnSituacaoUh? situacao = null)
        {
            return _repositorio.ObterUhsPorTipo(id, situacao);
        }

        public List<ItemDeSelecao<EnSituacaoUh>> ObterSituacoes()
        {
            return new List<ItemDeSelecao<EnSituacaoUh>>() {
                new ItemDeSelecao<EnSituacaoUh>(EnSituacaoUh.Livre, "Livre"),
                new ItemDeSelecao<EnSituacaoUh>(EnSituacaoUh.EmManutencao, "Manutenção"),
                new ItemDeSelecao<EnSituacaoUh>(EnSituacaoUh.Inativa, "Inativa")
            };
        }

        public void AtualizarSituacaoUh(Uh uh, EnSituacaoUh situacao)
        {
            uh.Situacao = situacao;
            this.Persistir(uh, EnOperacao.Update);
        }

        public List<ItemDeSelecao<bool>> ObterSimOuNao()
        {
            return new List<ItemDeSelecao<bool>>() {
                new ItemDeSelecao<bool>(true, "SIM"),
                new ItemDeSelecao<bool>(false, "NÃO")
            };
        }


        public override ObjetoDeValidacao Validar(Uh objeto)
        {
            var resultadoDaValidacao = new ObjetoDeValidacao();

            if (string.IsNullOrWhiteSpace(objeto.Numero))
            {
                resultadoDaValidacao.Criticas.Add("O número da UH deve ser informado.");
            }

            if(objeto.TipoUh == null || objeto.TipoUh == default(TipoUh))
            {
                resultadoDaValidacao.Criticas.Add("O Tipo da UH deve ser selecionado.");
            }

            return resultadoDaValidacao;
        }
    }
}
