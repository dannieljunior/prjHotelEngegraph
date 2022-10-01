using Hotel.Bll.IOC;
using Hotel.Comum.Dto;
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
    public class LancamentosBll : BllBase<Lancamentos, IRepositorioLancamentos>
    {
        public LancamentosBll()
        {
            _repositorio = Kernel.Get<IRepositorioLancamentos>();
        }
        public override ObjetoDeValidacao Validar(Lancamentos objeto)
        {
            throw new NotImplementedException();
        }
    }
}
