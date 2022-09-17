using Hotel.Bll.Classes;
using Hotel.Comum.Enumerados;
using Hotel.Comum.Modelos;
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
    public partial class FrmCadUsuario : Form
    {
        EnOperacao _operacao = EnOperacao.Insert;

        string _operacaoDescricao = "Inserindo dados";

        readonly UsuarioBll _bll = new UsuarioBll();

        Usuario _objeto = new Usuario();

        public bool IsSenhaChanged => _objeto?.Senha != txtSenha.Text;

        public string DescricaoOperacao
        {
            get { return _operacaoDescricao; }
            set
            {
                _operacaoDescricao = value;
                lblStatusOperacao.Text = _operacaoDescricao;
            }
        }

        public FrmCadUsuario()
        {
            InitializeComponent();
            DescricaoOperacao = "Inserindo dados";
            lblInfoLogin.Text = "";
            NovoRegistro();
        }

        private void NovoRegistro()
        {
            _objeto = new Usuario();
            _operacao = EnOperacao.Insert;
            txtLogin.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            txtConfirmaSenha.Clear();
            lblInfoLogin.Text = "";
            DescricaoOperacao = "Inserindo registro";
        }

        private void ucBarraBotoesPadrao1_OnNovoClick(object sender, EventArgs e)
        {
            NovoRegistro();
        }

        private void ucBarraBotoesPadrao1_OnConsultaClick(object sender, EventArgs e)
        {
            var dados = _bll.List();
            var formularioDeConsulta = new frmConsulta();

            formularioDeConsulta.SetList<Usuario>(dados);

            formularioDeConsulta.OnSelectRow = (s, evt) => {
                var idSelecionado = (Guid)evt.SelectedItem;

                _objeto = _bll.GetById(idSelecionado);

                txtLogin.Text = _objeto.Login;
                txtEmail.Text = _objeto.EMail;
                txtSenha.Text = _objeto.Senha;
                chkAtivo.Checked = _objeto.Ativo;
                txtConfirmaSenha.Clear();

                _operacao = EnOperacao.Update;
                DescricaoOperacao = "Alterando registro";
            };

            formularioDeConsulta.OnDeleteRow = (s, evt) =>
            {
                var idSelecionado = (Guid)evt.SelectedItem;
                _bll.Persistir(_objeto, EnOperacao.Delete);
                NovoRegistro();
            };

            formularioDeConsulta.ShowDialog();
        }

        private void ucBarraBotoesPadrao1_OnSalvarClick(object sender, EventArgs e)
        {
            try
            {
                if (IsSenhaChanged && txtConfirmaSenha.Text != txtSenha.Text)
                {
                    Notificador.Erro("As senhas não conferem.");
                    return;
                }

                _objeto.Login = txtLogin.Text;
                _objeto.EMail = txtEmail.Text;
                _objeto.Senha = txtSenha.Text;
                _objeto.Ativo = chkAtivo.Checked;

                var validacao = _bll.Validar(_objeto);

                if (!validacao.Sucesso)
                {
                    Notificador.Erro(string.Join(Environment.NewLine, validacao.Criticas.ToArray()));
                }
                else
                {
                    var msg = "";

                    if (_operacao == EnOperacao.Insert)
                    {
                        _objeto = _bll.Persistir(_objeto, EnOperacao.Insert);
                        msg = "inseridos";
                        _operacao = EnOperacao.Update;
                        DescricaoOperacao = "Alterando registro";
                    }
                    else
                    {
                        _bll.Persistir(_objeto, EnOperacao.Update);
                        msg = "atualizados";
                    }

                    Notificador.Sucesso($"Dados {msg} com sucesso!");
                }
            }
            catch (Exception ex)
            {
                Notificador.Erro($"Ocorreu um erro: {ex.Message}");
            }
        }
    }
}
