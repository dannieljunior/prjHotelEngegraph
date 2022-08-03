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
            AddFormInTabPage(new FrmCadTipoUh());
        }

        private void AddFormInTabPage(Form pForm)
        {
            if (tabForms.TabPages.Count > 5)
            {
                MessageBox.Show("Máximo de 6 formulários abertos atingidos", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            pForm.FormBorderStyle = FormBorderStyle.None;
            pForm.WindowState = FormWindowState.Maximized;
            pForm.TopLevel = false;
            var page = new TabPage();
            page.Controls.Add(pForm);
            page.Text = pForm.Text;
            tabForms.Controls.Add(page);
            pForm.Parent = page;
            pForm.Show();
        }

        private void mnUh_Click(object sender, EventArgs e)
        {
            AddFormInTabPage(new FrmCadUh());
        }

        private void fecharGuiaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
