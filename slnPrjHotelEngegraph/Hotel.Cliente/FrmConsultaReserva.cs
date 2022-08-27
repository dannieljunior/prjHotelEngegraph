using Hotel.Bll.Classes;
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
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            var dados = _bll.ObterReservas(dtaCheckIn.Value, dtaCheckOut.Value, cmbTipoUh.SelectedValue?.ToString());
            dataGridView1.DataSource = dados;
        }
    }
}
