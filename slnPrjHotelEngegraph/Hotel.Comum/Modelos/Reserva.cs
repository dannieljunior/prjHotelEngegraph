using Hotel.Comum.Enumerados;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel.Comum.Modelos
{
    [Table("Reserva")]
    public class Reserva: Entidade
    {
        [Column(TypeName = "varchar"), DisplayName("Nome do solicitante"), MaxLength(40), Required]
        public string NomeSolicitante { get; set; }
        [Column(TypeName = "varchar"), MaxLength(15), Required]
        public string TelefoneSolicitante { get; set; }
        [Required]
        public DateTime DataCheckIn { get; set; }
        [Required]
        public DateTime DataCheckOut { get; set; }
        [Required]
        public int QtdeAdt { get; set; }
        [Required, DefaultValue(0)]
        public int QtdeChd { get; set; }
        [ForeignKey("TipoUh"), Required]
        public Guid TipoUhId { get; set; }
        public virtual TipoUh TipoUh { get; set; }
        [Column(TypeName = "varchar"), MaxLength(200)]
        public string Observacoes { get; set; }
        [Required]
        [DefaultValue(0)]
        public EnSituacaoReserva Situacao { get; set; }

        [Column(TypeName = "varchar"), MaxLength(100), Required]
        public string EMailSolicitante { get; set; }
        [Column(TypeName = "varchar"), MaxLength(12), Required]
        public string Localizador { get; set; }
    }
}
