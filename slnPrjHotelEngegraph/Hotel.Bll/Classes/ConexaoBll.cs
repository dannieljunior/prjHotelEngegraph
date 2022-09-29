using Hotel.Repositorio.EF;
using System.Linq;

namespace Hotel.Bll.Classes
{
    public class ConexaoBll
    {
        public ConexaoBll(string stringCOnexao)
        {
            //Conexao.ConnectionString = stringCOnexao;
            //new ExecutorDeMigracoes();

            var c = new HotelDbContext();

            var teste = c.TiposPgto.ToList();
        }
    }
}
