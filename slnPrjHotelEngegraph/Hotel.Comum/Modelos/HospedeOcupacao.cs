using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel.Comum.Modelos
{
    [Table("HospedeOcupacao")]
    public class HospedeOcupacao: Entidade
    {
        [ForeignKey("Hospede"), Required]
        public virtual Guid HospedeId { get; set; }
        public Hospede Hospede { get; set; }
        [ForeignKey("Ocupacao"), Required]
        public Guid OcupacaoId { get; set; }
        public virtual Ocupacao Ocupacao { get; set; }
    }
}
