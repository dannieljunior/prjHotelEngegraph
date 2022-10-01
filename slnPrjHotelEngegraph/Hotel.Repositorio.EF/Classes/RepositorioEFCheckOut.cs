using Hotel.Comum.Interfaces;
using Hotel.Comum.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Repositorio.EF.Classes
{
    public class RepositorioEFCheckOut: RepositorioBase<CheckOut>, IRepositorioCheckOut
    {
        public override List<CheckOut> List()
        {
            return dbset.Include("Ocupacao").ToList();
        }
    }
}
