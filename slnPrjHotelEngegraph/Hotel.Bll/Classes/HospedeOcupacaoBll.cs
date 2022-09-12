using Hotel.Comum.Dto;
using Hotel.Comum.Interfaces;
using Hotel.Comum.Modelos;
using Hotel.Repositorio.ADO.Classes;
using System;
using System.Collections.Generic;

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

        public List<HospedeOcupacao> ObterHospedesPorOcupacao(Guid id)
        {
            return _repositorio.ObterHospedesPorOcupacao(id);
        }
    }
}
