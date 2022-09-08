using Hotel.Comum.Enumerados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Comum.ViewModels
{
    public class OcupacaoViewModel
    {
        public Guid UhId { get; set; }
        public string Numero { get; set; }
        public Guid OcupacaoId { get; set; }
        public EnSituacaoUh Situacao { get; set; }
    }
}
