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
    public partial class FrmLogin : Form
    {
        readonly UsuarioBll _bll = new UsuarioBll();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var resultado = _bll.Login(txtLogin.Text, txtSenha.Text);

            if (resultado.Sucesso)
                DialogResult = DialogResult.OK;
            else
            {
                Notificador.Erro(resultado.Mensagem);
            }
        }
    }
}
