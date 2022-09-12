using Hotel.Comum.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Comum.Interfaces
{
    public interface IRepositorio<T> where T: Entidade
    {
        T Insert(T obj);
        void Update(T obj);
        void Delete(Guid id);
        List<T> List();
        T GetById(Guid id);
    }
}
