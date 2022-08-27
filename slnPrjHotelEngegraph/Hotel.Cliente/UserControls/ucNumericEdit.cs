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
    public partial class ucNumericEdit : UserControl
    {
        public double Value
        {
            get
            {
                return Convert.ToDouble(txtControl.Text);
            }
            set
            {
                txtControl.Text = value.ToString("0.00");
            }
        }

        public ucNumericEdit()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            txtControl.Text = "0,00";
        }

        private void txtControl_Leave(object sender, EventArgs e)
        {
            txtControl.Text = Convert.ToDouble(txtControl.Text).ToString("0.00");
        }

        private void txtControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
