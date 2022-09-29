using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel.Comum.Modelos
{
    [Table("TipoPagto")]
    public class TipoPagto: Entidade
    {
        [Column(TypeName = "varchar"), MaxLength(40), Required]
        public string Descricao { get; set; }
    }
}
