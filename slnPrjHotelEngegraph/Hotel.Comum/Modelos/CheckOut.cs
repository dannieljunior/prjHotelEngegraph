using System;
using System.Collections.Generic;

namespace Hotel.Comum.Modelos
{
    public class CheckOut: Entidade
    {
        public DateTime DataCheckOut { get; set; }
        public Ocupacao Ocupacao { get; set; }
        public List<Lancamentos> Lancamentos { get; set; }
    }
}
