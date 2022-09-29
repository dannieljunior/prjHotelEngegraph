using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel.Comum.Modelos
{
    [Table("CheckOut")]
    public class CheckOut: Entidade
    {
        [Required]
        public DateTime DataCheckOut { get; set; }
        [ForeignKey("Ocupacao"), Required]
        public Guid OcupacaoId { get; set; }
        public virtual Ocupacao Ocupacao { get; set; }
        public virtual List<Lancamentos> Lancamentos { get; set; }
    }
}
