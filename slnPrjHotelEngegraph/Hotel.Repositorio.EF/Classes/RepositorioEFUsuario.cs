using Hotel.Comum.Interfaces;
using Hotel.Comum.Modelos;
using System.Linq;

namespace Hotel.Repositorio.EF.Classes
{
    public class RepositorioEFUsuario : RepositorioBase<Usuario>, IRepositorioUsuario
    {
        public RepositorioEFUsuario()
        {
            dbset = context.Usuarios;
        }
        public Usuario GetUserByLogin(string login)
        {
            return dbset.FirstOrDefault(x => x.Login == login);
        }
    }
}
