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
    public partial class ucMoneyTextBox : UserControl
    {
        const string VALOR_DEFAULT = "0,00";
        public ucMoneyTextBox()
        {
            InitializeComponent();
        }

        private void ucMoneyTextBox_Load(object sender, EventArgs e)
        {
            txt.Text = VALOR_DEFAULT;
            lbl.Text = Prefixo;
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        public decimal Valor {
            get { return !string.IsNullOrWhiteSpace(txt.Text) ? decimal.Parse(txt.Text) : 0.0M; }
            set { txt.Text = value.ToString("0.00");  }
        }
            
            
            

        public string Prefixo { get; set; }

        private void txt_Leave(object sender, EventArgs e)
        {
            try
            {
                txt.Text = decimal.Parse(txt.Text).ToString("0.00");
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao decimal");
                txt.Focus();
                txt.SelectAll();
            }
        }
    }
}
