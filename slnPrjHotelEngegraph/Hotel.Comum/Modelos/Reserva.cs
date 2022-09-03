using Hotel.Comum.Enumerados;
using System;

namespace Hotel.Comum.Modelos
{
    public class Reserva: Entidade
    {
        public string NomeSolicitante { get; set; }
        public string TelefoneSolicitante { get; set; }
        public DateTime DataCheckIn { get; set; }
        public DateTime DataCheckOut { get; set; }
        /// <summary>
        /// quantidade de adultos
        /// </summary>
        public int QtdeAdt { get; set; }
        /// <summary>
        /// quantidade de crianças
        /// </summary>
        public int QtdeChd { get; set; }
        public TipoUh TipoUh { get; set; }
        public string Observacoes { get; set; }
        public EnSituacaoReserva Situacao { get; set; }
        public string EMailSolicitante { get; set; }
        public string Localizador { get; set; }
    }
}
