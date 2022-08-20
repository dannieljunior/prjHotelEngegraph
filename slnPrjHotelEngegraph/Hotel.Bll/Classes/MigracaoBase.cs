using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Bll.Classes
{
    public abstract class MigracaoBase
    {
        protected int versao;
        public int Versao => versao;
        public abstract void Executar(SqlCommand comando);
    }
}
