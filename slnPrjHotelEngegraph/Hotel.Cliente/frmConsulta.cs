using Hotel.Cliente.Eventos;
using System;
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

        public frmConsulta(DataTable pTabela)
        {
            InitializeComponent();
            dataGridView1.DataSource = pTabela;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir o registro selecionado?", 
                                "Confirmação", 
                                MessageBoxButtons.YesNo, 
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    OnDeleteRow(sender, new MyEventArgs(dataGridView1.SelectedRows[0].Cells["Id"].Value));
                    dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
                    MessageBox.Show("Registro excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu o erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }              
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelecionar_Click_1(object sender, EventArgs e)
        {
            var selectedRow = dataGridView1.SelectedRows[0].Cells["Id"].Value;
            OnSelectRow(sender, new MyEventArgs(selectedRow));
            this.Close();
        }
    }
}
