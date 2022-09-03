using Hotel.Bll.Classes;
using Hotel.Comum.Enumerados;
using Hotel.Comum.Modelos;
using System;
using System.Windows.Forms;

namespace Hotel.Cliente
{
    public partial class FrmNovaReserva : Form
    {
        EnOperacao _operacao;
        readonly ReservaBll _bll = new ReservaBll();
        string _operacaoDescricao;
        Reserva _objeto;

        public string DescricaoOperacao
        {
            get { return _operacaoDescricao; }
            set
            {
                _operacaoDescricao = value;
                lblStatusOperacao.Text = _operacaoDescricao;
            }
        }

        public FrmNovaReserva()
        {
            Inicializar();
            NovoRegistro();
        }


        public FrmNovaReserva(Guid id)
        {
            Inicializar();
            _objeto = _bll.GetById(id);
            PreencherControles();
            _operacao = EnOperacao.Update;
            DescricaoOperacao = "Alterando registro";
        }

        private void PreencherControles()
        {
            txtSolicitante.Text = _objeto.NomeSolicitante;
            mskTefoneSolicitante.Text = _objeto.TelefoneSolicitante;
            txtEmailSolictante.Text = _objeto.EMailSolicitante;
            dtaCheckIn.Value = _objeto.DataCheckIn;
            dtaCheckOut.Value = _objeto.DataCheckOut;
            numQtdeAdt.Value = _objeto.QtdeAdt;
            numQtdeChd.Value = _objeto.QtdeChd;
            cmbTipoUh.SelectedValue = _objeto.TipoUh.Id;
            mmObservacoes.Text = _objeto.Observacoes;

            txtSolicitante.Focus();
        }

        private void Inicializar()
        {
            InitializeComponent();
            cmbTipoUh.DataSource = _bll.ObterTiposUh(false);
            cmbTipoUh.ValueMember = "Id";
            cmbTipoUh.DisplayMember = "Descricao";
        }

        
        private void NovoRegistro()
        {
            _objeto = new Reserva();
            _operacao = EnOperacao.Insert;

            txtSolicitante.Clear();
            txtEmailSolictante.Clear();
            mskTefoneSolicitante.Clear();
            
            numQtdeAdt.Value = 0;
            numQtdeChd.Value = 0;

            dtaCheckIn.Value = DateTime.Now.AddDays(1);
            dtaCheckOut.Value = DateTime.Now.AddDays(2);

            cmbTipoUh.SelectedIndex = 0;

            mmObservacoes.Clear();

            DescricaoOperacao = "Inserindo registro";

            txtSolicitante.Focus();
        }

        private void ucBarraBotoesPadrao1_OnFecharClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ucBarraBotoesPadrao1_OnSalvarClick(object sender, EventArgs e)
        {
            try
            {
                _objeto.NomeSolicitante = txtSolicitante.Text;
                _objeto.TelefoneSolicitante = mskTefoneSolicitante.Text;
                _objeto.EMailSolicitante = txtEmailSolictante.Text;

                _objeto.QtdeAdt = Convert.ToInt32(numQtdeAdt.Value);
                _objeto.QtdeChd = Convert.ToInt32(numQtdeChd.Value);

                _objeto.TipoUh = _bll.GetTipoUh((Guid)cmbTipoUh.SelectedValue);

                _objeto.DataCheckIn = dtaCheckIn.Value.Date;
                _objeto.DataCheckOut = dtaCheckOut.Value.Date;

                _objeto.QtdeAdt = Convert.ToInt32(numQtdeAdt.Value);
                _objeto.QtdeChd = (int)numQtdeChd.Value;
                _objeto.Observacoes = mmObservacoes.Text;

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
