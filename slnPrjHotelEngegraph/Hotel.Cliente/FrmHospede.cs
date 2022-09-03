using Hotel.Bll.Classes;
using Hotel.Cliente.Eventos;
using Hotel.Comum.Enumerados;
using Hotel.Comum.Modelos;
using Hotel.Comum.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.Cliente
{
    public partial class FrmHospede : Form
    {

        public EventHandler<HospedeEventArgs> OnSaveHospede;

        readonly HospedeBll _bll = new HospedeBll();
        HospedeViewModel _objeto;
        EnOperacao _operacao;
        string _operacaoDescricao;

        public string DescricaoOperacao
        {
            get { return _operacaoDescricao; }
            set
            {
                _operacaoDescricao = value;
                lblStatusOperacao.Text = _operacaoDescricao;
            }
        }

        public FrmHospede()
        {
            Inicializar();
            NovoRegistro();
        }

        public FrmHospede(HospedeViewModel objeto)
        {
            Inicializar();
            _objeto = objeto;
            CarregarControles();
            _operacao = EnOperacao.Update;
            DescricaoOperacao = "Atualizando registro";
        }

        private void NovoRegistro()
        {
            _objeto = new HospedeViewModel();

            txtNome.Clear();
            txtSobreNome.Clear();
            mmEndereco.Clear();
            txtDocumento.Clear();
            mskTefone.Clear();
            dtaNascimento.Value = DateTime.Now.AddYears(-18);
            rbMasculino.Checked = true;
            rbFeminino.Checked = false;
            chkEstrangeiro.Checked = false;

            _operacao = EnOperacao.Insert;
            DescricaoOperacao = "Inserindo registro";
        }

        private void CarregarControles()
        {
            txtNome.Text = _objeto.Nome;
            txtSobreNome.Text = _objeto.SobreNome;
            mmEndereco.Text = _objeto.Endereco;
            txtDocumento.Text = _objeto.NumeroDocumento;
            mskTefone.Text = _objeto.Telefone;
            dtaNascimento.Value = _objeto.DataNascimento;
            rbMasculino.Checked = _objeto.Genero == EnGenero.Masculino;
            rbFeminino.Checked = _objeto.Genero == EnGenero.Feminino;
            chkEstrangeiro.Checked = _objeto.IsEstrangeiro;
        }
    

        private void Inicializar()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ucBarraBotoesPadrao1_OnFecharClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ucBarraBotoesPadrao1_OnSalvarClick(object sender, EventArgs e)
        {
            try
            {
                _objeto.Nome = txtNome.Text;
                _objeto.SobreNome = txtSobreNome.Text;
                _objeto.DataNascimento = dtaNascimento.Value;
                _objeto.Genero = rbMasculino.Checked ? EnGenero.Masculino : EnGenero.Feminino;
                _objeto.Endereco = mmEndereco.Text;
                _objeto.NumeroDocumento = txtDocumento.Text;
                _objeto.Telefone = mskTefone.Text;
                _objeto.IsEstrangeiro = chkEstrangeiro.Checked;

                var validacao = _bll.Validar(new Hospede()
                {
                    Nome = _objeto.Nome,
                    SobreNome = _objeto.SobreNome,
                    DataNascimento = _objeto.DataNascimento,
                    Endereco = _objeto.Endereco,
                    Genero = _objeto.Genero,
                    IsEstrangeiro = _objeto.IsEstrangeiro,
                    NumeroDocumento = _objeto.NumeroDocumento,
                    Telefone = _objeto.Telefone
                });

                if (!validacao.Sucesso)
                {
                    Notificador.Erro(string.Join(Environment.NewLine, validacao.Criticas.ToArray()));
                }
                else
                {
                    var msg = "";

                    if (_operacao == EnOperacao.Insert)
                    {
                        _objeto.Id = Guid.NewGuid();
                        msg = "inseridos";
                    }
                    else
                    {
                        msg = "atualizados";
                    }

                    OnSaveHospede(sender, new HospedeEventArgs(_objeto, _operacao));

                    if(Notificador.Confirmacao($"Dados {msg} com sucesso. Deseja incluir um novo hóspede?"))
                    {
                        NovoRegistro();
                    }
                    else
                    {
                        _operacao = EnOperacao.Update;
                        DescricaoOperacao = "Alterando registro";
                    }
                }
            }
            catch (Exception ex)
            {
                Notificador.Erro($"Ocorreu um erro: {ex.Message}");
            }
        }

        private void ucBarraBotoesPadrao1_Load(object sender, EventArgs e)
        {

        }
    }
}
