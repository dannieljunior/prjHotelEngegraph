using Hotel.Bll.Classes;
using Hotel.Cliente.Eventos;
using Hotel.Comum.Enumerados;
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

namespace Hotel.Cliente.UserControls
{
    public partial class ucItemDeConfiguracao : UserControl
    {
        public EventHandler<ConfiguracaoEventArgs> OnSave;



        public Configuracao Configuracao { get; set; }


        public ucItemDeConfiguracao(Configuracao configuracao)
        {
            InitializeComponent();
            Configuracao = configuracao;
            SetarValor();
            SetarVisibidadeDosControles();
            lblDescricao.Text = $"{Configuracao.Codigo} - {Configuracao.Descricao}";
        }

        public ucItemDeConfiguracao()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Configuracao.Valor = ObterValor();
            OnSave(sender, new ConfiguracaoEventArgs(Configuracao));
        }

        private string ObterValor()
        {
            switch (Configuracao.Tipo)
            {
                case Comum.Enumerados.EnTipoConfiguracao.Texto:
                    return stringValor.Text;
                case Comum.Enumerados.EnTipoConfiguracao.Inteiro:
                    return intValor.Value.ToString();
                case Comum.Enumerados.EnTipoConfiguracao.Booleano:
                    return boolValor.Checked ? Constantes.TRUE : Constantes.FALSE;
                case Comum.Enumerados.EnTipoConfiguracao.DataHora:
                    return dateTimeValor.Value.ToString();
                case Comum.Enumerados.EnTipoConfiguracao.Numerico:
                    return DoubleValor.Value.ToString();
                default:
                    return string.Empty;
            }
        }

        private void SetarValor()
        {
            switch (Configuracao.Tipo)
            {
                case Comum.Enumerados.EnTipoConfiguracao.Texto:
                    stringValor.Text = Configuracao.Valor;
                    break;
                case Comum.Enumerados.EnTipoConfiguracao.Inteiro:
                    intValor.Value = Convert.ToInt32(Configuracao.Valor);
                    break;
                case Comum.Enumerados.EnTipoConfiguracao.Booleano:
                    boolValor.Checked = Configuracao.Valor == Constantes.TRUE;
                    break;
                case Comum.Enumerados.EnTipoConfiguracao.DataHora:
                    dateTimeValor.Value = Convert.ToDateTime(Configuracao.Valor);
                    break;
                case Comum.Enumerados.EnTipoConfiguracao.Numerico:
                    DoubleValor.Value = Convert.ToDouble(Configuracao.Valor);
                    break;
                default:
                    stringValor.Text = Configuracao.Valor;
                    break;
            }
        }

        private void SetarVisibidadeDosControles()
        {
            stringValor.Visible = Configuracao.Tipo == EnTipoConfiguracao.Texto;
            DoubleValor.Visible = Configuracao.Tipo == EnTipoConfiguracao.Numerico;
            boolValor.Visible = Configuracao.Tipo == EnTipoConfiguracao.Booleano;
            intValor.Visible = Configuracao.Tipo == EnTipoConfiguracao.Inteiro;
            dateTimeValor.Visible = Configuracao.Tipo == EnTipoConfiguracao.DataHora;


            DoubleValor.Top = stringValor.Top;
            boolValor.Top = stringValor.Top;
            intValor.Top = stringValor.Top;
            dateTimeValor.Top = stringValor.Top;
        }
    }
}
