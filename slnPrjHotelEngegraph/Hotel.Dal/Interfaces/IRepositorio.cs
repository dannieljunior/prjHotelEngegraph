using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Dal.Interfaces
{
    public interface IRepositorio<T>
    {
        T Incluir(T entidade);
        void Atualizar(T entidade);
        void Excluir(Guid id);
        List<T> Consulta();
    }
}
