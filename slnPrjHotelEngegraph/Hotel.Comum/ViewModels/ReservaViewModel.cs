using Hotel.Comum.Enumerados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Comum.ViewModels
{
    public class ReservaViewModel
    {
        private int DiariasPrevistas => DataCheckOut.Subtract(DataCheckIn).Days;
        
        public Guid Id { get; set; }
        public string Solicitante { get; set; }
        public DateTime DataCheckIn { get; set; }
        public DateTime DataCheckOut { get; set; }
        public int QtdeAdt { get; set; }
        public int QtdeChd { get; set; }
        public string TipoUhDescricao { get; set; }
        public string Estadia => $"{DataCheckIn.ToString("dd/MM/yyyy")} - {DataCheckOut.ToString("dd/MM/yyyy")} ({DiariasPrevistas} noite(s))";
        public double ValorDiaria { get; set; }
        public string ValorEstadiaPrevisto => (ValorDiaria * DiariasPrevistas).ToString("0.00");
        public EnSituacaoReserva Situacao { get; set; }

        public string SituacaoReservaDescricao => ObterDescricaoSituacao();

        private string ObterDescricaoSituacao()
        {
            var result = "";

            switch (this.Situacao)  
            {
                case EnSituacaoReserva.Pendente: 
                    result = "Pendente";
                    break;
                case EnSituacaoReserva.Aberta:
                    result = "Aberta";
                    break;
                case EnSituacaoReserva.Concluida:
                    result = "Concluída";
                    break;
                case EnSituacaoReserva.Cancelada:
                    result = "Cancelada";
                    break;
                case EnSituacaoReserva.NoShow:
                    result = "NO SHOW";
                    break;
                default:
                    break;
            }

            return result;
        }

    }
}
