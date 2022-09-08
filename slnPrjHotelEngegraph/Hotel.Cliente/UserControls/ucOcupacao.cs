using Hotel.Cliente.Eventos;
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
    public partial class ucOcupacao : UserControl
    {
        public EventHandler<IdEventArgs> OnCheckOutClick;
        public EventHandler<IdEventArgs> OnLiberarManutencaoClick;
        public EventHandler<IdEventArgs> OnReativarClick;

        public Guid OcupacaoId { get; set; }

        public Guid UhId { get; set; }

        private bool _isOpen = false;

        public bool IsOpen
        {
            get { return _isOpen; }
            set
            {
                _isOpen = value;
                pictureBox1.Image = _isOpen ? Properties.Resources.door_open : Properties.Resources.door_close;
            }
        }

        private bool _isMaintenance = false;

        public bool IsMaintenance
        {
            get { return _isMaintenance; }
            set 
            { 
                _isMaintenance = value;
                pnlManutencao.Visible = IsMaintenance;
                IsOpen = value ? false : _isOpen;
            }
        }

        public string Numero
        {
            get { return label1.Text; }
            set
            {
                label1.Text = value;
            }
        }


        public ucOcupacao()
        {
            InitializeComponent();
        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(OnCheckOutClick != null)
            {
                OnCheckOutClick(sender, new IdEventArgs(OcupacaoId));
            }
        }

        private void liberarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(OnLiberarManutencaoClick != null)
            {
                OnLiberarManutencaoClick(sender, new IdEventArgs(UhId));
            }
        }

        private void reativarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OnReativarClick != null)
            {
                OnReativarClick(sender, new IdEventArgs(UhId));
            }
        }
    }
}
