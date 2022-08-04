using Hotel.Comum.Dto;
using Hotel.Comum.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Negocio.Contratos
{
    interface IBll<T> where T : Entidade
    {
        ObjValidacao Validar(T obj) ;
    }
}
