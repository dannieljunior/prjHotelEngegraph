using Hotel.Comum.Enumerados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Comum.ViewModels
{
    public class MapaOcupacaoViewModel
    {

        public Guid Id { get; set; }
        public string Numero { get; set; }
        public string Bloco { get; set; }
        public string Nivel { get; set; }
        public DateTime DataCheckIn { get; set; }
        public EnSituacaoUh Situacao { get; set; }
        public DateTime DataCheckOut { get; set; }
        public Guid OcupacaoId { get; set; }
    }
}
