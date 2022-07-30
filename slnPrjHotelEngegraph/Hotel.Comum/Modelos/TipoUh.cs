using System.Collections.Generic;

namespace Hotel.Comum.Modelos
{
    public class TipoUh: Entidade
    {
        public string Descricao { get; set; }
        /// <summary>
        /// quantidade de adultos
        /// </summary>
        public int QtdeAdt { get; set; }
        /// <summary>
        /// quantidade de crianças
        /// </summary>
        public int QtdeChd { get; set; }
        public double ValorDiaria { get; set; }
        public double ValorAdicional { get; set; }
        public List<Uh> Uhs { get; set; }
        public List<Reserva> Reservas { get; set; }
    }
}
