using Hotel.Bll.Classes;
using Hotel.Comum.Enumerados;
using Hotel.Comum.Modelos;
using System;
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

        readonly TipoUhBll _bll = new TipoUhBll();

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
                    Notificador.Erro(string.Join(Environment.NewLine, validacao.Criticas.ToArray()));
                }
                else
                {
                    var msg = "";

                    if(_operacao == EnOperacao.Insert)
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
            catch(Exception ex)
            {
                Notificador.Erro($"Ocorreu um erro: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dados = _bll.GetDataTable();
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
                _bll.Persistir(_objeto, EnOperacao.Delete);
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

        private void FrmCadTipoUh_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
