using Hotel.Bll.IOC;
using Hotel.Comum.Dto;
using Hotel.Comum.Interfaces;
using Hotel.Comum.IOC;
using Hotel.Comum.Modelos;
using Hotel.Repositorio.ADO.Classes;

namespace Hotel.Bll.Classes
{
    public class TipoPagtoBll : BllBase<TipoPagto, IRepositorioTipoPagto>
    {

        public TipoPagtoBll()
        {
            _repositorio = Kernel.Get<IRepositorioTipoPagto>();
        }

        public override ObjetoDeValidacao Validar(TipoPagto objeto)
        {
            var resultadoValidacao = new ObjetoDeValidacao();

            if (string.IsNullOrWhiteSpace(objeto.Descricao))
            {
                resultadoValidacao.Criticas.Add("Descrição deve ser preenchida.");
            }

            return resultadoValidacao;
        }
    }
}
