using Hotel.Bll.Classes;
using Hotel.Comum.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.Cliente
{
    public partial class FrmCadTipoUh : Form
    {
        readonly TipoUhBll _bll = new TipoUhBll(new SqlConnection(@"Server=2K21-DELL\SQLEXPRESS;Database=HotelEngegraph;User=sa;Password=123456"));
        
        TipoUh _objeto = new TipoUh();

        public FrmCadTipoUh()
        {
            InitializeComponent();
            //InicializarBindings();
        }

        //private void InicializarBindings()
        //{
        //    txtDescricao.DataBindings.Add(new Binding("Text", _objeto, "Descricao"));
        //    numQtdeAdt.DataBindings.Add(new Binding("Value", _objeto, "QtdeAdt"));
        //    numQtdeChd.DataBindings.Add(new Binding("Value", _objeto, "QtdeChd"));
        //    txtValorDiaria.DataBindings.Add(new Binding("Text", _objeto, "ValorDiaria"));
        //    txtValorAdicional.DataBindings.Add(new Binding("Text", _objeto, "ValorAdicional"));
        //}

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                _objeto.Descricao = txtDescricao.Text;
                _objeto.QtdeAdt = Convert.ToInt32(numQtdeAdt.Value);
                _objeto.QtdeChd = (int)numQtdeChd.Value;
                _objeto.ValorDiaria = Convert.ToDouble(txtValorDiaria.Text);
                _objeto.ValorAdicional = Convert.ToDouble(txtValorAdicional.Text);

                var validacao = _bll.Validar(_objeto);
                
                if (!validacao.Sucesso)
                {
                    MessageBox.Show(string.Join(Environment.NewLine, validacao.Criticas.ToArray()), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    _bll.Insert(_objeto);
                    MessageBox.Show("Dados inseridos com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Algo deu errado: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dados = _bll.ObterTabela();

            //var dataTable = new DataTable();
            //dataTable.Clear();
            //dataTable.Columns.Add("Id");
            //dataTable.Columns.Add("Descricao");

            //dataTable.Columns.Add("QtdeAdt");
            //dataTable.Columns.Add("QtdeChd");

            //dataTable.Columns.Add("ValorDiaria");
            //dataTable.Columns.Add("ValorAdicional");

            //dataTable.Columns.Add("DataCriacao");
            //dataTable.Columns.Add("DataModificacao");

            //foreach (var item in dados)
            //{
            //    DataRow linha = dataTable.NewRow();
            //    linha["Id"] = item.Id;
            //    linha["Descricao"] = item.Descricao;
            //    linha["QtdeAdt"] = item.QtdeAdt;
            //    linha["QtdeChd"] = item.QtdeChd;
            //    linha["ValorDiaria"] = item.ValorDiaria;
            //    linha["ValorAdicional"] = item.ValorAdicional;
            //    linha["DataCriacao"] = item.DataCriacao;
            //    linha["DataModificacao"] = item.DataModificacao;
            //    dataTable.Rows.Add(linha);
            //}

            var formularioDeConsulta = new frmConsulta(dados);
            formularioDeConsulta.ShowDialog();
        }
    }
}
