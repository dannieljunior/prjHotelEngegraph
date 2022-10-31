using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel.Comum.Modelos
{
    [Table("TipoUh")]
    public class TipoUh: Entidade
    {
        [Column(TypeName = "varchar"),
         Required, 
         MaxLength(40)]
        public string Descricao { get; set; }
        
        [Required]
        [DefaultValue(0)]
        public int QtdeAdt { get; set; }
        
        [Required]
        [DefaultValue(0)]
        public int QtdeChd { get; set; }

        [Required]
        [DefaultValue(0.00)]
        public double ValorDiaria { get; set; }

        [Required]
        [DefaultValue(0.00)]
        public double ValorAdicional { get; set; }

        [JsonIgnore]
        public virtual List<Uh> Uhs { get; set; }
    }
}
