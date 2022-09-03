using Hotel.Comum.Dto;
using Hotel.Comum.Interfaces;
using Hotel.Comum.Modelos;
using Hotel.Repositorio.ADO.Classes;
using System;

namespace Hotel.Bll.Classes
{
    public class HospedeOcupacaoBll : BllBase<HospedeOcupacao, IRepositorioHospedeOcupacao>
    {
        public HospedeOcupacaoBll()
        {
            _repositorio = new RepositorioADOHospedeOcupacao();
        }
        public override ObjetoDeValidacao Validar(HospedeOcupacao objeto)
        {
            throw new NotImplementedException();
        }
    }
}
