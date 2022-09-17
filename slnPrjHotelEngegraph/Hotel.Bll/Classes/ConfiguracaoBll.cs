using Hotel.Comum.Dto;
using Hotel.Comum.Interfaces;
using Hotel.Comum.Modelos;
using Hotel.Repositorio.ADO.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Bll.Classes
{
    public class ConfiguracaoBll : BllBase<Configuracao, IRepositorioConfiguracao>
    {
        public ConfiguracaoBll()
        {
            _repositorio = new RepositorioADOConfiguracao();
        }
        public override ObjetoDeValidacao Validar(Configuracao objeto)
        {
            throw new NotImplementedException();
        }



    }
}
