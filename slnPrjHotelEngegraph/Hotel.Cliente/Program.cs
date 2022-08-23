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

            /* TODO: Criar migrações de todas as tabelas do banco de dados
             * TODO: Desenhar todos os formulários
             * TODO: Migrar metodos de banco de dados para Repositorios
             * TODO: Criar os Repositorios  de todas as entidades
             * TODO: Programar o front end de todos os formularíos e seus respectivos acessos a dados
             * TODO: Criar a injeção de dependencia para futuramente "virar a chave" do ADO para o Entity
             * */

            Application.Run(new FrmMain());
        }
    }
}
