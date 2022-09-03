using Hotel.Comum.Enumerados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Comum.ViewModels
{
    public class HospedeViewModel
    {
        const int IDADE_CHD = 12; //isso depois será um parâmetro

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string NomeCompleto => $"{SobreNome}, {Nome}";
        public DateTime DataNascimento { get; set; }
        public EnGenero Genero { get; set; }
        public string GeneroDescricao => Genero == EnGenero.Masculino ? "MASCULINO" : "FEMININO";
        public string NumeroDocumento { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public bool IsEstrangeiro { get; set; }
        public string Nacionalidade => IsEstrangeiro ? "Estrangeiro" : "Brasileiro";
        public string ClassiFicacaoHospede => DateTime.Now.Subtract(DataNascimento).TotalDays / 365 > IDADE_CHD ? "ADULTO" : "CRIANCA";
    }
}
