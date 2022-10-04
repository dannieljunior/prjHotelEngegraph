using Hotel.Comum.Interfaces;
using Hotel.Comum.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Repositorio.EF.Classes
{
    public class RepositorioEFLancamentos: RepositorioBase<Lancamentos>, IRepositorioLancamentos
    {
        public RepositorioEFLancamentos()
        {
            dbset = context.Lancamentos;
        }
        public override List<Lancamentos> List()
        {
            return dbset.Include("CheckOut").ToList();
        }
    }
}
