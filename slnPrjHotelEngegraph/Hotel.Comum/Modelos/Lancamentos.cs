using Hotel.Comum.Enumerados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Comum.Modelos
{
    public class Lancamentos: Entidade
    {
        public double Valor { get; set; }
        public TipoPagto TipoPagto { get; set; }
        public CheckOut CheckOut { get; set; }
        public EnContaLancamento Conta { get; set; }
        public DateTime Data { get; set; }
    }
}
