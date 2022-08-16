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
    public partial class frmConsulta : Form
    {
        public frmConsulta()
        {
            InitializeComponent();
        }

        public frmConsulta(DataTable pTabela)
        {
            InitializeComponent();
            dataGridView1.DataSource = pTabela;
        }
    }
}
