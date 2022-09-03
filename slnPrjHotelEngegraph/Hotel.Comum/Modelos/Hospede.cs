using Hotel.Comum.Enumerados;
using System;

namespace Hotel.Comum.Modelos
{
    public class Hospede: Entidade
    {
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public DateTime DataNascimento { get; set; }
        public EnGenero Genero { get; set; }
        public string NumeroDocumento { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public bool IsEstrangeiro { get; set; }
    }
}
