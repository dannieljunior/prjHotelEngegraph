using Hotel.Comum.Enumerados;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel.Comum.Modelos
{
    [Table("Ocupacao")]
    public class Ocupacao: Entidade
    {
        [Required]
        public DateTime DataCheckIn { get; set; }
        [Required]
        public EnSituacaoOcupacao Situacao { get; set; }
        [ForeignKey("Reserva"), Required]
        public Guid ReservaId { get; set; }
        public virtual Reserva Reserva { get; set; }
        [ForeignKey("Uh"), Required]
        public Guid UhId { get; set; }
        public virtual Uh Uh { get; set; }
    }
}
