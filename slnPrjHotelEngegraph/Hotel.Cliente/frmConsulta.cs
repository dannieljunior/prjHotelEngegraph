using Hotel.Cliente.Eventos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace Hotel.Cliente
{
    public partial class frmConsulta : Form
    {
        public EventHandler<MyEventArgs> OnSelectRow;
        public EventHandler<MyEventArgs> OnDeleteRow;

        public frmConsulta()
        {
            InitializeComponent();
        }

        public void SetList<T>(List<T> pList)
        {
            dataGridView1.DataSource = new BindingList<T>(pList);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Notificador.Confirmacao("Deseja realmente excluir o registro selecionado?",
                () =>
                {
                    try
                    {
                        OnDeleteRow(sender, new MyEventArgs(dataGridView1.SelectedRows[0].Cells["Id"].Value));
                        dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
                        Notificador.Sucesso("Registro excluído com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        Notificador.Erro($"Ocorreu o erro: {ex.Message}");
                    }
                });
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelecionar_Click_1(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0].Cells["Id"].Value;
                OnSelectRow(sender, new MyEventArgs(selectedRow));
                this.Close();
            }
        }
    }
}
