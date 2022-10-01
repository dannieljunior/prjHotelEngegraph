using Hotel.Comum.Interfaces;
using Hotel.Comum.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Repositorio.EF.Classes
{
    public class RepositorioEFUsuario : RepositorioBase<Usuario>, IRepositorioUsuario
    {
        public Usuario GetUserByLogin(string login)
        {
            return dbset.FirstOrDefault(x => x.Login == login);
        }
    }
}
