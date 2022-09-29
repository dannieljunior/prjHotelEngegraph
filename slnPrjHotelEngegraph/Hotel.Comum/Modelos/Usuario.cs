using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Comum.Modelos
{
    [Table("Usuario")]
    public class Usuario: Entidade
    {
        [Column(TypeName = "varchar"), MaxLength(40), Required]
        public string Login { get; set; }
        [Column(TypeName = "varchar"), MaxLength(200), Required]
        public string Senha { get; set; }
        [Column(TypeName = "varchar"), MaxLength(100), Required]
        public string EMail { get; set; }
        [Required]
        public bool Ativo { get; set; }
        public int Tentativas { get; set; }
        [Required]
        public DateTime DataExpiracao { get; set; }
    }
}
