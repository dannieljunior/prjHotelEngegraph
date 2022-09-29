using Hotel.Comum.Enumerados;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel.Comum.Modelos
{
    [Table("Configuracao")]
    public class Configuracao: Entidade
    {
        [Required]
        public int Codigo { get; set; }
        [Column(TypeName = "varchar"), MaxLength(75), Required]
        public string Descricao { get; set; }
        [Column(TypeName = "varchar"), DefaultValue(""), MaxLength(400), Required]
        public string Valor { get; set; }
        [Required]
        public EnTipoConfiguracao Tipo { get; set; }
    }
}
