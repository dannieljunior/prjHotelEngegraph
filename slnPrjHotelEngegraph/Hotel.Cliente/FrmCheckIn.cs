using Hotel.Bll.Classes;
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
    public partial class FrmCheckIn : Form
    {

        BindingList<HospedeViewModel> _hospedes = new BindingList<HospedeViewModel>();

        readonly OcupacaoBll _bll = new OcupacaoBll();
        Ocupacao _objeto;

        public FrmCheckIn(Guid id)
        {
            InitializeComponent();

            dtgVwHospedes.AutoGenerateColumns = false;

            _objeto = new Ocupacao();

            dtgVwReserva.AutoGenerateColumns = false;

            _objeto.Reserva = _bll.ObterReservaPorId(id);
            var dadosReserva = _bll.ObterDadosDaReserva(_objeto.Reserva.Id);
            dtgVwReserva.DataSource = new List<ReservaViewModel>() { dadosReserva };
            mmObervacoes.Text = _objeto.Reserva.Observacoes;

            cmbUhs.DataSource = _bll.ObterUhs(_objeto.Reserva.TipoUh.Id);
            cmbUhs.DisplayMember = "Numero";
            cmbUhs.ValueMember = "Id";


            dtgVwHospedes.DataSource = _hospedes;

            AtualizarHospedes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new FrmHospede();
            
            frm.OnSaveHospede = (s, evt) =>
            {
                ManipularHospedes(evt.Hospede, evt.Operacao);
            };

            frm.ShowDialog();
        }

        private void AtualizarHospedes()
        {
            dtgVwHospedes.DataSource = _hospedes;
        }


        private void ManipularHospedes(HospedeViewModel hospede, EnOperacao operacao)
        {
            if (operacao == EnOperacao.Insert)
            {
                _hospedes.Add(hospede);
            }
            else
            {
                var hospedeParaAtualizar = _hospedes.FirstOrDefault(x => x.Id == hospede.Id);

                if(hospedeParaAtualizar != null)
                {
                    _hospedes.Remove(hospedeParaAtualizar);
                    _hospedes.Add(hospede);
                }
            }
                
            AtualizarHospedes();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var hospedeParaAtualizar = (dtgVwHospedes.DataSource as BindingList<HospedeViewModel>)[dtgVwHospedes.CurrentRow.Index];

            if(hospedeParaAtualizar != null)
            {
                var frm = new FrmHospede(hospedeParaAtualizar);

                frm.OnSaveHospede = (s, evt) =>
                {
                    ManipularHospedes(evt.Hospede, evt.Operacao);
                };

                frm.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var hospedeParaExcluir = (dtgVwHospedes.DataSource as BindingList<HospedeViewModel>)?[dtgVwHospedes.CurrentRow.Index];

            if (hospedeParaExcluir != null && Notificador.Confirmacao("Deseja realmente remover o hóspede da lista?"))
            {
                _hospedes.Remove(hospedeParaExcluir);
            }
        }
    }
}
