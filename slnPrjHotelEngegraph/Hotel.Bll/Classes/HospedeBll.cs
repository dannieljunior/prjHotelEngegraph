using Hotel.Bll.IOC;
using Hotel.Comum.Dto;
using Hotel.Comum.Helpers;
using Hotel.Comum.Interfaces;
using Hotel.Comum.IOC;
using Hotel.Comum.Modelos;
using Hotel.Comum.ViewModels;
using Hotel.Repositorio.ADO.Classes;
using System;

namespace Hotel.Bll.Classes
{
    public class HospedeBll : BllBase<Hospede, IRepositorioHospede>
    {
        readonly ConfiguracaoBll _configuracaoBll;
        public HospedeBll()
        {
            _repositorio = Kernel.Get<IRepositorioHospede>(); 
            _configuracaoBll = new ConfiguracaoBll();
        }

        public int IdadeMaximaCrianca => _configuracaoBll?.ObterConfiguracaoPeloCodigo(1001).ToInt() ?? 12;

        public override ObjetoDeValidacao Validar(Hospede objeto)
        {
            var resultadoValidacao = new ObjetoDeValidacao();

            if (string.IsNullOrWhiteSpace(objeto.Nome))
            {
                resultadoValidacao.Criticas.Add("Nome é obrigatório.");
            }

            if (string.IsNullOrWhiteSpace(objeto.SobreNome))
            {
                resultadoValidacao.Criticas.Add("SobreNome é obrigatório.");
            }

            if (string.IsNullOrWhiteSpace(objeto.Telefone))
            {
                resultadoValidacao.Criticas.Add("Telefone é obrigatório.");
            }

            if (string.IsNullOrWhiteSpace(objeto.Endereco))
            {
                resultadoValidacao.Criticas.Add("Endereço é obrigatório.");
            }

            if (string.IsNullOrWhiteSpace(objeto.NumeroDocumento))
            {
                resultadoValidacao.Criticas.Add("Documento é obrigatório.");
            }

            return resultadoValidacao;
        }
    }
}
