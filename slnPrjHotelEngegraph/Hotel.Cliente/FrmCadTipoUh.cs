using Hotel.Comum.Modelos;
using Hotel.Negocio.Classes;
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
    public partial class FrmCadTipoUh : Form
    {
        readonly TipoUhBll _negocio = new TipoUhBll();
        TipoUh _obj;
        public FrmCadTipoUh()
        {
            InitializeComponent();
            inicializarBindings();
        }

        private void FrmCadTipoUh_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void inicializarBindings()
        {
            _obj = new TipoUh();

            txtDescricao.DataBindings.Add(new Binding("text", _obj, "Descricao", true, DataSourceUpdateMode.OnPropertyChanged));
            numQtdeAdt.DataBindings.Add(new Binding("Value", _obj, "QtdeAdt", true, DataSourceUpdateMode.OnPropertyChanged));
            numQtdeChd.DataBindings.Add(new Binding("Value", _obj, "QtdeChd", true, DataSourceUpdateMode.OnPropertyChanged));
            mnVlrDiariaNormal.DataBindings.Add(new Binding("Valor", _obj, "ValorDiaria", true, DataSourceUpdateMode.OnPropertyChanged));
            mnVlrDiariaAdicional.DataBindings.Add(new Binding("Valor", _obj, "ValorAdicional", true, DataSourceUpdateMode.OnPropertyChanged));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //_obj.Descricao = txtDescricao.Text;
            //_obj.QtdeAdt = (int)numQtdeAdt.Value;
            //_obj.QtdeChd = (int)numQtdeAdt.Value;
            //_obj.ValorDiaria = (double)mnVlrDiariaNormal.Valor;
            //_obj.ValorAdicional = (double)mnVlrDiariaAdicional.Valor;

            var validacao = _negocio.Validar(_obj);

            if (!validacao.Sucesso)
                MessageBox.Show(string.Join(Environment.NewLine, validacao.Criticas.ToArray()));

        }

        private void button3_Click(object sender, EventArgs e)
        {
            _obj = new TipoUh()
            {
                Descricao = "Single STD",
                QtdeAdt = 1,
                QtdeChd = 0,
                ValorDiaria = 99
            };
        }
    }
}