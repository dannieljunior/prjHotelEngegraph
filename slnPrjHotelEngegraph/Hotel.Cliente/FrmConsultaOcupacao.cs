using Hotel.Bll.Classes;
using Hotel.Cliente.UserControls;
using Hotel.Comum.Enumerados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.Cliente
{
    public partial class FrmConsultaOcupacao : Form
    {
        readonly OcupacaoBll _Bll = new OcupacaoBll();
        public FrmConsultaOcupacao()
        {
            InitializeComponent();
            ExibirMapaDeOcupacao();
        }

        private void ExibirMapaDeOcupacao()
        {
            AtualizarInformacao();

            var ocupacoes = _Bll.ObterMapaDeOcupacao();

            ocupacoes.ForEach(ocupacao =>
            {
                var control = new ucOcupacao()
                {
                    UhId = ocupacao.UhId,
                    IsOpen = ocupacao.Situacao == EnSituacaoUh.Livre,
                    Numero = ocupacao.Numero,
                    IsMaintenance = ocupacao.Situacao == EnSituacaoUh.EmManutencao,
                    OcupacaoId = ocupacao.OcupacaoId
                };

                if (ocupacao.Situacao == EnSituacaoUh.Ocupada)
                {
                    control.OnCheckOutClick = (s, e) =>
                    {
                        ShowCheckOut(e.Id);
                    };
                }

                if(ocupacao.Situacao == EnSituacaoUh.EmManutencao)
                {
                    control.OnLiberarManutencaoClick = (s, e) =>
                    {
                        LiberarManutencaoUh(e.Id);
                    };
                }

                if (ocupacao.Situacao == EnSituacaoUh.Inativa)
                {
                    control.OnLiberarManutencaoClick = (s, e) =>
                    {
                        ReativarUh(e.Id);
                    };
                }

                flwOcupacoes.Controls.Add(control);
            });
        }

        private void ShowCheckOut(Guid id)
        {
            Notificador.Informacao($"Check-Out do Id {id.ToString()}");
        }

        private void ReativarUh(Guid id)
        {
            Notificador.Informacao($"Reativar UH:  {id.ToString()}");
        }

        private void LiberarManutencaoUh(Guid id)
        {
            Notificador.Informacao($"Liberando UH: {id.ToString()}");
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tmrInformacao_Tick(object sender, EventArgs e)
        {
            AtualizarInformacao();
        }

        private void AtualizarInformacao()
        {
            lblInformacao.Text = $"Ocupação em {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}";
        }
    }
}
