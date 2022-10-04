using Hotel.Comum.Enumerados;
using Hotel.Comum.Interfaces;
using Hotel.Comum.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Repositorio.EF.Classes
{
    public class RepositorioEFUh : RepositorioBase<Uh>, IRepositorioUh
    {
        public RepositorioEFUh()
        {
            dbset = context.Uhs;
        }

        public override Uh GetById(Guid id)
        {
            return dbset.Include("TipoUh").FirstOrDefault(x => x.Id == id);
        }

        public override List<Uh> List()
        {
            return dbset.Include("TipoUh").ToList();
        }
        public List<Uh> ObterUhsPorTipo(Guid tipoUhId, EnSituacaoUh? situacao)
        {
            var query = dbset.Include("TipoUh").Where(x => x.TipoUh.Id == tipoUhId);

            if (situacao != null)
                query = query.Where(x => x.Situacao == situacao);

            return query.ToList();
        }
    }
}
