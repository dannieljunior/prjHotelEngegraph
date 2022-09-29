using System;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Comum.Modelos
{
    public abstract class Entidade
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public DateTime DataCriacao { get; set; }
        public DateTime? DataModificacao { get; set; }
    }
}
