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
    public partial class FrmCadUh : Form
    {
        EnOperacao _operacao = EnOperacao.Insert;

        string _operacaoDescricao = "Inserindo dados";

        readonly UhBll _bll = new UhBll();

        Uh _objeto = new Uh();

        public string DescricaoOperacao
        {
            get { return _operacaoDescricao; }
            set
            {
                _operacaoDescricao = value;
                lblStatusOperacao.Text = _operacaoDescricao;
            }
        }

        public FrmCadUh()
        {
            InitializeComponent();
            DescricaoOperacao = "Inserindo dados";

            var tiposUh = _bll.ObterTiposUh();

            cmbTipoUh.DataSource = tiposUh;
            cmbTipoUh.DisplayMember = "Descricao";
            cmbTipoUh.ValueMember = "Id";

            var situacoes = _bll.ObterSituacoes();

            cmbSituacao.DataSource = situacoes;
            cmbSituacao.DisplayMember = "Descricao";
            cmbSituacao.ValueMember = "Valor";
        }

        private void NovoRegistro()
        {
            _objeto = new Uh();
            _operacao = EnOperacao.Insert;
            txtNumero.Clear();
            txtBloco.Clear();
            txtNivel.Clear();
            cmbTipoUh.SelectedIndex = -1;
            cmbSituacao.SelectedIndex = -1;
            txtNumero.Focus();
            DescricaoOperacao = "Inserindo registro";
        }

        private void ucBarraBotoesPadrao1_OnNovoClick(object sender, EventArgs e)
        {
            NovoRegistro();
        }

        private void ucBarraBotoesPadrao1_OnConsultaClick(object sender, EventArgs e)
        {
            var dados = _bll.GetDataTable();
            var formularioDeConsulta = new frmConsulta(dados);

            formularioDeConsulta.OnSelectRow = (s, evt) => {
                var idSelecionado = (Guid)evt.SelectedItem;

                _objeto = _bll.GetById(idSelecionado);

                txtNumero.Text = _objeto.Numero;
                txtBloco.Text = _objeto.Bloco;
                txtNivel.Text = _objeto.Nivel;
                cmbTipoUh.SelectedValue = _objeto.TipoUh.Id;
                cmbSituacao.SelectedValue = _objeto.Situacao;

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
                _objeto.Numero = txtNumero.Text;
                _objeto.Bloco = txtBloco.Text;
                _objeto.Nivel = txtNivel.Text;
                _objeto.TipoUh = _bll.GetTipoUh((Guid)cmbTipoUh.SelectedValue);
                _objeto.Situacao = (EnSituacaoUh)cmbSituacao.SelectedValue;

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
