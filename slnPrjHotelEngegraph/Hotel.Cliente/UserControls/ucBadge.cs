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
    public partial class ucBadge : UserControl
    {

        public string Display
        {
            get
            {
                return lblDisplay.Text;
            }
            set
            {
                lblDisplay.Text = value;
            }
        }

        public string Value
        {
            get
            {
                return lblValue.Text;
            }
            set
            {
                lblValue.Text = value;
            }
        }

        public ucBadge()
        {
            InitializeComponent();
        }
    }
}
