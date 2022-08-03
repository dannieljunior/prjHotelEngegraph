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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Text = string.Concat(SistemaInfo.NomeSistema, " ", SistemaInfo.Versao);
            Width = SistemaInfo.LarguraDaTela;
            Height = SistemaInfo.AlturadaTela;
            CenterToScreen();
        }

        private void mnSobre_Click(object sender, EventArgs e)
        {
            new FrmSobre().ShowDialog();
        }

        private void mnTipoUh_Click(object sender, EventArgs e)
        {
            var frm = new FrmCadTipoUh();
            frm.Parent = pnlPai;
            frm.Show();
        }

        private void mnUh_Click(object sender, EventArgs e)
        {
            var frm = new FrmCadUh();
            frm.ShowDialog();
        }
    }
}
