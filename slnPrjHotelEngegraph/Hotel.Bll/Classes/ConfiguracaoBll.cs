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
    public class ConfiguracaoBll : BllBase<Configuracao, IRepositorioConfiguracao>
    {
        public ConfiguracaoBll()
        {
            _repositorio = Kernel.Get<IRepositorioConfiguracao>();
        }
        public override ObjetoDeValidacao Validar(Configuracao objeto)
        {
            throw new NotImplementedException();
        }

        public string ObterConfiguracaoPeloCodigo(int codigo)
        {
            return _repositorio.ObterConfiguracaoPeloCodigo(codigo);
        }
    }
}
