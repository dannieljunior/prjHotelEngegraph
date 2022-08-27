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

        readonly TipoUhBll _bll = new TipoUhBll();

        TipoUh _objeto = new TipoUh();

        public string DescricaoOperacao
        {
            get { return _operacaoDescricao; }
            set
            {
                _operacaoDescricao = value;
                lblStatusOperacao.Text = _operacaoDescricao;
            }
        }

        public FrmCadTipoUh()
        {
            InitializeComponent();
            DescricaoOperacao = "Inserindo dados";
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

                txtDescricao.Text = _objeto.Descricao;
                txtValorDiaria.Value = _objeto.ValorDiaria;
                txtValorAdicional.Value = _objeto.ValorAdicional;
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

        private void ucBarraBotoesPadrao1_OnSalvarClick(object sender, EventArgs e)
        {
            try
            {
                _objeto.Descricao = txtDescricao.Text;
                _objeto.QtdeAdt = Convert.ToInt32(numQtdeAdt.Value);
                _objeto.QtdeChd = (int)numQtdeChd.Value;
                _objeto.ValorDiaria = txtValorDiaria.Value;
                _objeto.ValorAdicional = txtValorAdicional.Value;

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

        private void ucBarraBotoesPadrao1_Load(object sender, EventArgs e)
        {

        }
    }
}
