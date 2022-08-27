using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.Cliente.UserControls
{
    public partial class ucBarraBotoesPadrao : UserControl
    {

        public event EventHandler OnNovoClick;
        public event EventHandler OnSalvarClick;
        public event EventHandler OnFecharClick;
        public event EventHandler OnConsultaClick;

        public ucBarraBotoesPadrao()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            OnNovoClick(sender, e);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            OnSalvarClick(sender, e);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if(OnFecharClick == null)
            {
                var frmParent = (Form)this.Parent;
                var page = (TabPage)frmParent.Parent;
                var controlPai = (TabControl)page.Parent;
                controlPai.Controls.Remove(page);
                frmParent.Close();
            }
            else
            {
                OnFecharClick(sender, e);
            }
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            OnConsultaClick(sender, e);
        }
    }
}
