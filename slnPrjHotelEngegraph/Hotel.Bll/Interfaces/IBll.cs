using Hotel.Comum.Dto;
using Hotel.Comum.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Bll.Interfaces
{
    public interface IBll<T>
    {
        ObjetoDeValidacao Validar(T objeto);

        T Insert(T obj);
        void Update(T obj);
        void Delete(Guid id);
        List<T> List();
        T GetById(Guid id);
    }
}
