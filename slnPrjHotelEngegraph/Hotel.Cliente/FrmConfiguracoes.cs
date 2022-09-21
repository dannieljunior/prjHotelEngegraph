using Hotel.Bll.Classes;
using Hotel.Cliente.UserControls;
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
                    Notificador.Sucesso("A configuração foi alterada com sucesso.");
                };

                flwConfiguracoes.Controls.Add(item);
            });
        }
    }
}
