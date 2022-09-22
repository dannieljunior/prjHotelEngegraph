using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void DelMensagemSemRetornoESemParametro();
    public delegate void DelMensagemSemRetornoEComParametro(string mensagem);
    public delegate string DelMensagemComRetornoESemParametro();
    public delegate string DelMensagemComRetornoEComParametro(string mensagem);

    public delegate int DelSomaDoisNumeros(int num1, int num2);

    public delegate double CalculaDevolucao(double valorEmolumento);

    public delegate double DelCalculaIcms(ProdutoServico p);
    public delegate double DelCalculaIss(ProdutoServico p);
    public delegate double DelCalculaIpi(ProdutoServico p);

}
