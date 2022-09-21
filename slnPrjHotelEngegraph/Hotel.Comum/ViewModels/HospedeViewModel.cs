using Hotel.Comum.Auxiliares;
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
        private int _idade_chd = 12;

        public HospedeViewModel(int idadeMaximaCrianca = 12)
        {
            _idade_chd = idadeMaximaCrianca;
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string NomeCompleto => $"{SobreNome}, {Nome}";
        public DateTime DataNascimento { get; set; }
        public EnGenero Genero { get; set; }
        public string GeneroDescricao => Genero == EnGenero.Masculino ? Constantes.MASCULINO : Constantes.FEMININO;
        public string NumeroDocumento { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public bool IsEstrangeiro { get; set; }
        public string Nacionalidade => IsEstrangeiro ? Constantes.ESTRANGEIRO : Constantes.BRASILEIRO;
        public string ClassiFicacaoHospede => DateTime.Now.Subtract(DataNascimento).TotalDays / 365 > _idade_chd ? Constantes.ADULTO : Constantes.CRIANCA;
    }
}
