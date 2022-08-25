using Hotel.Comum.Auxiliares;
using Hotel.Comum.Dto;
using Hotel.Comum.Enumerados;
using Hotel.Comum.Modelos;
using Hotel.Repositorio.ADO.Classes;
using System;
using System.Collections.Generic;
using System.Data;

namespace Hotel.Bll.Classes
{
    public class UhBll : BllBase<Uh>
    {
        protected readonly TipoUhBll _tipoUhBll;
        public UhBll()
        {
            _repositorio = new RepositorioADOUh();
            _tipoUhBll = new TipoUhBll();
        }

        public DataTable ObterTiposUh()
        {
            return _tipoUhBll.GetDataTable();
        }

        public TipoUh GetTipoUh(Guid id)
        {
            return _tipoUhBll.GetById(id);
        }

        public List<ItemDeSelecao<EnSituacaoUh>> ObterSituacoes()
        {
            return new List<ItemDeSelecao<EnSituacaoUh>>() {
                new ItemDeSelecao<EnSituacaoUh>(EnSituacaoUh.Livre, "Livre"),
                new ItemDeSelecao<EnSituacaoUh>(EnSituacaoUh.Ocupada, "Ocupada"),
                new ItemDeSelecao<EnSituacaoUh>(EnSituacaoUh.EmManutencao, "Manutenção"),
                new ItemDeSelecao<EnSituacaoUh>(EnSituacaoUh.Inativa, "Inativa")
            };
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
