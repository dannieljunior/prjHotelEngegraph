using Hotel.Comum.Interfaces;
using Hotel.Comum.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Repositorio.EF.Classes
{
    public class RepositorioEFHospede: RepositorioBase<Hospede>, IRepositorioHospede
    {
        public RepositorioEFHospede()
        {
            dbset = context.Hospedes;
        }
    }
}
