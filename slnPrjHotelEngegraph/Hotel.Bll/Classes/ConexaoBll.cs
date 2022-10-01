using Hotel.Bll.IOC;
using Hotel.Comum.IOC;
using Hotel.Repositorio.ADO;
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

            Kernel.Initialize(new[] { new EFModule() });
        }
    }
}
