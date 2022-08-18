using Hotel.Bll.Classes;
using Hotel.Comum.Enumerados;
using Hotel.Comum.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.Cliente
{
    public partial class FrmCadTipoUh : Form
    {
        EnOperacao _operacao = EnOperacao.Insert;

        string _operacaoDescricao = "Inserindo dados";
        public string DescricaoOperacao
        {
            get { return _operacaoDescricao; }
            set
            {
                _operacaoDescricao = value;
                lblStatusOperacao.Text = _operacaoDescricao;
            }
        }

        readonly TipoUhBll _bll = new TipoUhBll(new SqlConnection(@"Server=2K21-DELL\SQLEXPRESS;Database=HotelEngegraph;User=sa;Password=123456"));

        TipoUh _objeto = new TipoUh();

        public FrmCadTipoUh()
        {
            InitializeComponent();
            DescricaoOperacao = "Inserindo dados";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                _objeto.Descricao = txtDescricao.Text;
                _objeto.QtdeAdt = Convert.ToInt32(numQtdeAdt.Value);
                _objeto.QtdeChd = (int)numQtdeChd.Value;
                _objeto.ValorDiaria = Convert.ToDouble(txtValorDiaria.Text);
                _objeto.ValorAdicional = Convert.ToDouble(txtValorAdicional.Text);

                var validacao = _bll.Validar(_objeto);
                
                if (!validacao.Sucesso)
                {
                    MessageBox.Show(string.Join(Environment.NewLine, validacao.Criticas.ToArray()), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var msg = "";

                    if(_operacao == EnOperacao.Insert)
                    {
                        _objeto = _bll.Insert(_objeto);
                        msg = "inseridos";
                        _operacao = EnOperacao.Update;
                        DescricaoOperacao = "Alterando registro";
                    }
                    else
                    {
                        _bll.Update(_objeto);
                        msg = "atualizados";
                    }

                    MessageBox.Show($"Dados {msg} com sucesso!", "Sucesso", 
                                    MessageBoxButtons.OK, 
                                    MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", 
                                  MessageBoxButtons.OK, 
                                  MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dados = _bll.ObterTabela();
            var formularioDeConsulta = new frmConsulta(dados);

            formularioDeConsulta.OnSelectRow = (s, evt) => {
                var idSelecionado = (Guid)evt.SelectedItem;

                _objeto = _bll.GetById(idSelecionado);

                txtDescricao.Text = _objeto.Descricao;
                txtValorDiaria.Text = _objeto.ValorDiaria.ToString("0.00");
                txtValorAdicional.Text = _objeto.ValorAdicional.ToString("0.00");
                numQtdeAdt.Value = _objeto.QtdeAdt;
                numQtdeChd.Value = _objeto.QtdeChd;

                _operacao = EnOperacao.Update;
                DescricaoOperacao = "Alterando registro";
            };

            formularioDeConsulta.OnDeleteRow = (s, evt) =>
            {
                var idSelecionado = (Guid)evt.SelectedItem;
                _bll.Delete(idSelecionado);
                NovoRegistro();
            };

            formularioDeConsulta.ShowDialog();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            //fechar a tab control do formulário
            var page = (TabPage)this.Parent;
            var controlPai = (TabControl)page.Parent;
            controlPai.Controls.Remove(page);
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            NovoRegistro();
        }

        private void NovoRegistro()
        {
            _objeto = new TipoUh();
            _operacao = EnOperacao.Insert;
            txtDescricao.Clear();
            txtValorDiaria.Clear();
            txtValorAdicional.Clear();
            numQtdeAdt.Value = 0;
            numQtdeChd.Value = 0;
            txtDescricao.Focus();
            DescricaoOperacao = "Inserindo registro";
        }
    }
}
