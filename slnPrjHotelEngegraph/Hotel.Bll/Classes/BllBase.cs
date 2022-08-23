using Hotel.Comum.Enumerados;
using Hotel.Comum.Interfaces;
using Hotel.Comum.Modelos;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Hotel.Bll.Classes
{
    public abstract class BllBase<T> where T: Entidade
    {
        protected IRepositorio<T> _repositorio;
    }
}
