using Hotel.Comum.Dto;
using Hotel.Comum.Interfaces;
using Hotel.Comum.Modelos;
using Hotel.Repositorio.ADO.Classes;

namespace Hotel.Bll.Classes
{
    public class TipoUhBll : BllBase<TipoUh, IRepositorioTipoUh>
    {
        public TipoUhBll()
        {
            _repositorio = new RepositorioADOTipoUh();
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

            if (objeto.ValorAdicional < 0)
            {
                result.Criticas.Add("Valor adicional não pode ser um valor negativo.");
            }

            return result;
        }
    }
}
