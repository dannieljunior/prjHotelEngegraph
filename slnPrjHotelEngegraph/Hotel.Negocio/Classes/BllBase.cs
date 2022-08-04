using Hotel.Comum.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Negocio.Classes
{
    public abstract class BllBase
    {
        protected readonly ObjValidacao _resultadoValidacao = new ObjValidacao();
    }
}
