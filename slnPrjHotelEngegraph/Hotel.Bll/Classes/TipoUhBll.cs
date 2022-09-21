using Hotel.Comum.Dto;
using Hotel.Comum.Helpers;
using Hotel.Comum.Interfaces;
using Hotel.Comum.Modelos;
using Hotel.Repositorio.ADO.Classes;

namespace Hotel.Bll.Classes
{
    public class TipoUhBll : BllBase<TipoUh, IRepositorioTipoUh>
    {

        readonly ConfiguracaoBll _configuracaoBll;
        public TipoUhBll()
        {
            _repositorio = new RepositorioADOTipoUh();
            _configuracaoBll = new ConfiguracaoBll();
        }

        public override ObjetoDeValidacao Validar(TipoUh objeto)
        {
            var result = new ObjetoDeValidacao();

            if (string.IsNullOrWhiteSpace(objeto.Descricao))
            {
                result.Criticas.Add("Descrição deve ser informada.");
            }

            if(objeto.QtdeAdt <= 0)
            {
                result.Criticas.Add("Quantidade de adultos deve ser maior que zero.");
            }

            if(objeto.QtdeChd < 0)
            {
                result.Criticas.Add("Quantidade de crianças não pode ser negativa.");
            }

            if(objeto.ValorDiaria <= 0)
            {
                result.Criticas.Add("Valor da diária deve ser informado");
            }

            var valorMinimoDiaria = _configuracaoBll.ObterConfiguracaoPeloCodigo(1004).ToInt();

            if (objeto.ValorDiaria < valorMinimoDiaria)
            {
                result.Criticas.Add("(1004) O Valor das diária não segue a política do hotel de valor mínimo de diária.");
            }

            if (objeto.ValorAdicional < 0)
            {
                result.Criticas.Add("Valor adicional não pode ser um valor negativo.");
            }

            return result;
        }
    }
}
