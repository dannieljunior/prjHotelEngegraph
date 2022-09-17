using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Comum.Modelos
{
    public class Usuario: Entidade
    {
        public string Login { get; set; }
        public string Senha { get; set; }
        public string EMail { get; set; }
        public bool Ativo { get; set; }
        public int Tentativas { get; set; }
        public DateTime DataExpiracao { get; set; }
    }
}
