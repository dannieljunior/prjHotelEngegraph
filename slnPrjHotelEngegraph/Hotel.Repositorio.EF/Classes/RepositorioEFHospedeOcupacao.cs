using Hotel.Comum.Interfaces;
using Hotel.Comum.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Repositorio.EF.Classes
{
    public class RepositorioEFHospedeOcupacao : RepositorioBase<HospedeOcupacao>, IRepositorioHospedeOcupacao
    {
        public RepositorioEFHospedeOcupacao()
        {
            dbset = context.HospedesOcupacao;
        }
        public override List<HospedeOcupacao> List()
        {
            return dbset.Include("Hospede").Include("Ocupacao").ToList();
        }
        public List<HospedeOcupacao> ObterHospedesPorOcupacao(Guid id)
        {
            return dbset.Include("Ocupacao").Include("Hospede").Where(x => x.Ocupacao.Id == id).ToList();
        }
    }
}
