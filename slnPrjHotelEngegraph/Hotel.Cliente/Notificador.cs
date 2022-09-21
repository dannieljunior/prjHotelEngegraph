using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.Cliente
{
    class Notificador
    {
        public static void Sucesso(string mensagem)
        {
            MessageBox.Show(mensagem, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Informacao(string mensagem)
        {
            MessageBox.Show(mensagem, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Erro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool Confirmacao(string mensagem, Action acaoSim = null, Action acaoNao = null)
        {
            if(acaoSim == null && acaoNao == null)
            {
                return MessageBox.Show(mensagem,
                                "Confirmação",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes;
            }
            else
            {
                var result = MessageBox.Show(mensagem,
                                "Confirmação",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                    acaoSim();
                else
                {
                    if(acaoNao != null)
                        acaoNao();
                }

                return false;
            }
        }
    }
}
