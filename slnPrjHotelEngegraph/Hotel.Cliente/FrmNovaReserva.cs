using Hotel.Bll.Classes;
using Hotel.Comum.Enumerados;
using Hotel.Comum.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Hotel.Cliente
{
    public partial class FrmNovaReserva : Form
    {
        EnOperacao _operacao;
        readonly ReservaBll _bll = new ReservaBll();
        string _operacaoDescricao;
        Reserva _objeto;

        public int QtdeNoites
        {
            get
            {
                var result = _objeto != null ? Convert.ToInt32(dtaCheckOut.Value.Subtract(dtaCheckIn.Value).TotalDays) : 0;
                bdgNoites.Value = result < 0 ? "0" : result.ToString();
                return result;
            }
        }

        public double ValorDiaria
        {
            get
            {
                var result = (cmbTipoUh.DataSource as DataTable)?.Rows[cmbTipoUh.SelectedIndex]["ValorDiaria"];
                bdgValorDiaria.Value = result == null ? "0,00" : Convert.ToDouble(result).ToString("0.00");
                return Convert.ToDouble(result);
            }
        }

        public double ValorTotal => ValorDiaria * QtdeNoites;

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
            bdgLocalizador.Value = _objeto.Localizador;

            txtSolicitante.Focus();
        }

        private void Inicializar()
        {
            InitializeComponent();
            cmbTipoUh.DataSource = _bll.ObterTiposUh(false);
            cmbTipoUh.ValueMember = "Id";
            cmbTipoUh.DisplayMember = "Descricao";

            bdgSituacao.Value = _objeto?.Situacao.ToString() ?? "Pendente";
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
                        bdgLocalizador.Value = _objeto.Localizador;
                    }
                    else
                    {
                        if(_objeto.Situacao != EnSituacaoReserva.Pendente)
                        {
                            Notificador.Informacao("Não é possível alterar dados de uma reserva com situação diferente de \"pendente\"");
                            return;
                        }

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

        private void dtaCheckIn_ValueChanged(object sender, EventArgs e)
        {
            NotificarPropriedades();
        }

        private void dtaCheckOut_ValueChanged(object sender, EventArgs e)
        {
            NotificarPropriedades();
        }

        private void cmbTipoUh_SelectedValueChanged(object sender, EventArgs e)
        {
            NotificarPropriedades();
        }

        private void NotificarPropriedades()
        {
            var x = QtdeNoites;
            var y = ValorDiaria;
            var z = ValorTotal;
            bdgValorTotal.Value = ValorTotal.ToString("0.00");
        }
    }
}
