using Hotel.Comum.Enumerados;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel.Comum.Modelos
{
    [Table("Lancamentos")]
    public class Lancamentos: Entidade
    {
        [DefaultValue(0.00)]
        public double Valor { get; set; }
        [ForeignKey("TipoPagto")]
        public Guid TipoPagtoId { get; set; }
        public virtual TipoPagto TipoPagto { get; set; }
        [ForeignKey("CheckOut")]
        public Guid CheckOutId { get; set; }
        public virtual CheckOut CheckOut { get; set; }
        [Required]
        public EnContaLancamento Conta { get; set; }
        [Required]
        public DateTime Data { get; set; }
    }
}
