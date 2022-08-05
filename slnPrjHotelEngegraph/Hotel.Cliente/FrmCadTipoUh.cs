﻿using Hotel.Bll.Classes;
using Hotel.Comum.Modelos;
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
        readonly TipoUhBll _bll = new TipoUhBll();
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
            }
            catch
            {
                MessageBox.Show("Algo deu errado.");
            }
        }
    }
}
