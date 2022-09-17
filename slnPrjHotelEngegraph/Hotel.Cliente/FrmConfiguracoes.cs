using Hotel.Bll.Classes;
using Hotel.Cliente.UserControls;
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
    public partial class FrmConfiguracoes : Form
    {

        readonly ConfiguracaoBll _bll = new ConfiguracaoBll();
        public FrmConfiguracoes()
        {
            InitializeComponent();

            MontarItens();
        }

        private void MontarItens()
        {
            var dados = _bll.List();

            dados.ForEach(configuracao =>
            {
                var item = new ucItemDeConfiguracao(configuracao);

                item.OnSave = (s, e) => {
                    _bll.Persistir(e.Configuracao, Comum.Enumerados.EnOperacao.Update);
                };

                flwConfiguracoes.Controls.Add(item);
            });
        }
    }
}
