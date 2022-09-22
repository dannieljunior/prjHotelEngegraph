using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    public delegate void MensagemSemRetornoSemParametro();
    public delegate void MensagemSemRetornoComParametro(string mensagem);
    public delegate string MensagemComRetornoEComParametro(string mensagem);
    public delegate int SomaDoisNumeros(int num1, int num2);
}
