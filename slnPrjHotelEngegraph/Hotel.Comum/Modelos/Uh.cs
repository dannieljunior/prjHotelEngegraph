using Hotel.Comum.Enumerados;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel.Comum.Modelos
{
    [Table("Uh")]
    public class Uh: Entidade
    {
        [Column(TypeName = "varchar"), MaxLength(15)]
        public string Numero { get; set; }
        [Column(TypeName = "varchar"), MaxLength(15)]
        public string Bloco { get; set; }
        [Column(TypeName = "varchar"), MaxLength(15)]
        public string Nivel { get; set; }
        [ForeignKey("TipoUh"), Required]
        public Guid TipoUhId { get; set; }
        public virtual TipoUh TipoUh { get; set; }
        [Required]
        public EnSituacaoUh Situacao { get; set; }
    }
}
