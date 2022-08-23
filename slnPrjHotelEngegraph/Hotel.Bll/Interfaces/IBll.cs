using Hotel.Comum.Dto;
using Hotel.Comum.Enumerados;
using Hotel.Comum.Interfaces;
using Hotel.Comum.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Bll.Interfaces
{
    public interface IBll<T> where T: Entidade
    {
        ObjetoDeValidacao Validar(T objeto);
        T Persistir(T obj, EnOperacao operacao);
        DataTable GetDataTable();
        T GetById(Guid id);
    }
}
