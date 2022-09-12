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
    public partial class frmCadTipoPagto : Form
    {
        readonly TipoPagtoBll _bll = new TipoPagtoBll();
        EnOperacao _operacao = EnOperacao.Insert;
        string _descricaoOperacao = "Inserindo novo registro";
        TipoPagto _objeto;

        public frmCadTipoPagto()
        {
            InitializeComponent();
            NovoRegistro();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ucBarraBotoesPadrao1_OnNovoClick(object sender, EventArgs e)
        {
            NovoRegistro();
        }

        private void NovoRegistro()
        {
            _objeto = new TipoPagto();
            _descricaoOperacao = "Inserindo novo registro";
            _operacao = EnOperacao.Insert;
            txtDescricao.Clear();
            txtDescricao.Focus();
            lblStatusOperacao.Text = _descricaoOperacao;
        }

        private void ucBarraBotoesPadrao1_OnConsultaClick(object sender, EventArgs e)
        {
            var dados = _bll.List();
            var formularioDeConsulta = new frmConsulta();

            formularioDeConsulta.SetList<TipoPagto>(dados);

            formularioDeConsulta.OnSelectRow = (s, evt) => {
                var idSelecionado = (Guid)evt.SelectedItem;

                _objeto = _bll.GetById(idSelecionado);

                txtDescricao.Text = _objeto.Descricao;

                _operacao = EnOperacao.Update;
                _descricaoOperacao = "Alterando registro";

                lblStatusOperacao.Text = _descricaoOperacao;
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
                _objeto.Descricao = txtDescricao.Text;

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
                        _descricaoOperacao = "Alterando registro";

                        lblStatusOperacao.Text = _descricaoOperacao;
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
