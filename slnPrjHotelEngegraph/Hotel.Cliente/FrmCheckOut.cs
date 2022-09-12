using Hotel.Bll.Classes;
using Hotel.Comum.Enumerados;
using Hotel.Comum.Modelos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Hotel.Cliente
{
    public partial class FrmCheckOut : Form
    {
        readonly CheckOutBll _bll = new CheckOutBll();
        Ocupacao _objetoOcupacao;


        public int QtdeDiarias { get; set; }
        public double ValorDiaria { get; set; }
        public double ValorTotalDiarias { get; set; }


        public FrmCheckOut(Guid id)
        {
            InitializeComponent();
            lblDataCheckOut.Text = $"Data do Check-Out: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}";

            _objetoOcupacao = _bll.GetOcupacaoById(id);

            CarregarInformacoes();
        }

        private void CarregarInformacoes()
        {
            dtgOcupacao.DataSource = new List<Ocupacao>() { _objetoOcupacao };
            dtgHospedes.DataSource = _bll.ObterHospedes(_objetoOcupacao.Id);

            cmbFPagtoDiarias.DataSource = _bll.ObterFormasDePagamento();
            cmbFPagtoConsumo.DataSource = _bll.ObterFormasDePagamento();

            cmbFPagtoDiarias.ValueMember = "Id";
            cmbFPagtoDiarias.DisplayMember = "Descricao";

            cmbFPagtoConsumo.ValueMember = "Id";
            cmbFPagtoConsumo.DisplayMember = "Descricao";

            QtdeDiarias = Convert.ToInt32(DateTime.Now.Subtract(_objetoOcupacao.DataCheckIn).TotalDays);
            ValorDiaria = _objetoOcupacao.Reserva.TipoUh.ValorDiaria;
            ValorTotalDiarias = QtdeDiarias * ValorDiaria;

            numQtdeDiarias.Value = QtdeDiarias;
            numVlrDiaria.Value = ValorDiaria;
            numVlrTotalDiarias.Value = ValorTotalDiarias;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Notificador.Confirmacao("Deseja realmente confirmar o Check-Out nesta ocupação?"))
                {
                    var objetoCheckOut = new CheckOut()
                    {
                        DataCheckOut = DateTime.Now,
                        Ocupacao = _objetoOcupacao
                    };

                    var Lancamentos = new List<Lancamentos>()
                    {
                        new Lancamentos()
                        {
                            Data = objetoCheckOut.DataCheckOut,
                            Conta = EnContaLancamento.HOSPEDAGEM,
                            Valor = ValorTotalDiarias,
                            TipoPagto = _bll.ObterFormaDePagamentoById((Guid)cmbFPagtoDiarias.SelectedValue)
                        },
                        new Lancamentos()
                        {
                            CheckOut = objetoCheckOut,
                            Data = objetoCheckOut.DataCheckOut,
                            Conta = EnContaLancamento.CONSUMO,
                            Valor = numVlrConsumo.Value,
                            TipoPagto = _bll.ObterFormaDePagamentoById((Guid)cmbFPagtoConsumo.SelectedValue)
                        }
                    };

                    objetoCheckOut.Lancamentos = Lancamentos;

                    _bll.Persistir(objetoCheckOut, EnOperacao.Insert);

                    Notificador.Sucesso("Check-Out confimado com sucesso!");
                    this.Close();
                }
            }
            catch (Exception erro)
            {
                Notificador.Erro($"Ocorreu o erro: {erro.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
