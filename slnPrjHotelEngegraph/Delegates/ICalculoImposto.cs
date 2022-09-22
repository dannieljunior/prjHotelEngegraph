using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public interface ICalculoImposto
    {
        double CalculaIcms(ProdutoServico produto);
        double CalculaIss(ProdutoServico produto);
        double CalculaIPI(ProdutoServico produto);
    }
}
