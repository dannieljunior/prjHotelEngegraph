using Hotel.Bll.Classes;
using Hotel.Repositorio.ADO;
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

            Conexao.ConnectionString = ConfigurationManager.AppSettings["StringDeConexao"];

            new ExecutorDeMigracoes();

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
        }
    }
}
