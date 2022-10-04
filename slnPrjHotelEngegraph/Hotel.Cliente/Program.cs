using Hotel.Bll.Classes;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace Hotel.Cliente
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            new ConexaoBll(ConfigurationManager.AppSettings["StringDeConexao"]);

        #if (DEBUG)

            FrmLogin frm = new FrmLogin();

            var result = frm.ShowDialog();

            if(result == DialogResult.Cancel)
            {
                Application.Exit();
            }
            else
            {
                Application.Run(new FrmMain());
            }
        #endif
        #if (!DEBUG)
            Application.Run(new FrmMain());
        #endif

        }
    }
}
