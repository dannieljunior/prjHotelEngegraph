using Hotel.Comum.Enumerados;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel.Comum.Modelos
{
    [Table("Hospede")]
    public class Hospede: Entidade
    {
        [Column(TypeName = "varchar"), MaxLength(40), Required]
        public string Nome { get; set; }
        [Column(TypeName = "varchar"), MaxLength(40), Required]
        public string SobreNome { get; set; }
        [Required]
        public DateTime DataNascimento { get; set; }
        [Required]
        public EnGenero Genero { get; set; }
        [Column(TypeName = "varchar"), MaxLength(40), Required]
        public string NumeroDocumento { get; set; }
        [Column(TypeName = "varchar"), MaxLength(15), Required]
        public string Telefone { get; set; }
        [Column(TypeName = "varchar"), MaxLength(200), Required]
        public string Endereco { get; set; }
        [Required]
        public bool IsEstrangeiro { get; set; }
        public DateTime? DataCasamento { get; set; }
    }
}
