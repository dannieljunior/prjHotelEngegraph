using Hotel.Bll.Classes;
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
    public partial class FrmConsultaReserva : Form
    {

        readonly ReservaBll _bll = new ReservaBll();

        public FrmConsultaReserva()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;

            cmbTipoUh.DataSource = _bll.ObterTiposUh();
            cmbTipoUh.ValueMember = "Id";
            cmbTipoUh.DisplayMember = "Descricao";
            cmbTipoUh.SelectedValue = default(Guid);
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            ConsultarReservas();
        }

        private void ConsultarReservas()
        {
            var dados = _bll.ObterReservas(dtaCheckIn.Value, dtaCheckOut.Value, cmbTipoUh.SelectedValue?.ToString());
            dataGridView1.DataSource = dados;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new FrmNovaReserva();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var reservaId = (dataGridView1.DataSource as List<ReservaViewModel>)[dataGridView1.CurrentRow.Index].Id;
                var frm = new FrmNovaReserva(reservaId);
                frm.ShowDialog();
                ConsultarReservas();
            }
            catch
            {
                Notificador.Informacao("Nenhuma reserva selecionada.");
            }
        }

        private void btnChekIn_Click(object sender, EventArgs e)
        {
            var reservaId = (dataGridView1.DataSource as List<ReservaViewModel>)?[dataGridView1.CurrentRow.Index].Id;
            if(reservaId != null)
            {
                var frm = new FrmCheckIn(reservaId ?? default);
                frm.ShowDialog();
                ConsultarReservas();
            }
        }
    }
}
