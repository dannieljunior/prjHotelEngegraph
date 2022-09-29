using System;
using System.Collections.Generic;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaDeProdutosEServicos = new List<ProdutoServico>()
            {
                new ProdutoServico
                {
                    Descricao = "Cerveja Heineken Long Neck",
                    Valor = 12.00,
                    IsProduto = true,
                    IsServico = false,
                    IsProdutoIndustrializado = false
                },
                new ProdutoServico
                {
                    Descricao = "Taxa de Servico",
                    Valor = 12.00,
                    IsServico = true,
                    IsProduto = false,
                    IsProdutoIndustrializado = false
                },
                new ProdutoServico
                {
                    Descricao = "Nissan Kicks",
                    Valor = 80000.00,
                    IsProdutoIndustrializado = true,
                    IsServico = false,
                    IsProduto = false,
                }
            };


            var uf = "GO";

            ICalculoImposto motorDeCalculoDeImpostos = null;

            if (uf == "GO")
                motorDeCalculoDeImpostos = new CalculoImpostoGO();
            if (uf == "MG")
                motorDeCalculoDeImpostos = new CalculoImpostoMG();
            if (uf == "DF")
                motorDeCalculoDeImpostos = new CalculoImpostoDF();

            listaDeProdutosEServicos.ForEach(ps =>
            {
                //ps.Valor += RetornaValorDoProdutoOuServico(motorDeCalculoDeImpostos.CalculaIcms,
                //                                           motorDeCalculoDeImpostos.CalculaIss,
                //                                           motorDeCalculoDeImpostos.CalculaIPI,
                //                                           ps);

                ps.Valor += RetornaValorDoProdutoOuServico(motorDeCalculoDeImpostos, ps);

                Console.WriteLine($"Descrição: {ps.Descricao} - Valor: {ps.Valor.ToString("0.00")}");
            });

            Console.ReadKey();
        }

        static double RetornaValorDoProdutoOuServico(DelCalculaIcms icms, DelCalculaIss iss, DelCalculaIpi ipi, ProdutoServico ps)
        {
            return icms(ps) + iss(ps) + ipi(ps);
        }

        static double RetornaValorDoProdutoOuServico(ICalculoImposto motordeCalculo, ProdutoServico ps)
        {
            return motordeCalculo.CalculaIcms(ps) + motordeCalculo.CalculaIss(ps) + motordeCalculo.CalculaIPI(ps);
        }

        static double Calcula25PorCento(double valor)
        {
            return valor * 0.25;
        }

        static double Calcula75PorCento(double valor)
        {
            return valor * 0.75;
        }

        static void Mensagem()
        { 
            Console.WriteLine("Olá mundo");
        }

        static void MensagemSemRetornoEComParametro(string mensagem)
        {
            Console.WriteLine(mensagem);
        }

        static string MensagemComRetornoSemParametro()
        {
            return "Olá mundo";
        }

        static string MensagemComRetornoEComParametro(string texto)
        {
            return texto + " mundo";
        }

        static int SomaDoisNumeros(int a, int b)
        {
            return a + b;
        }

        static double Calcular(double valorEmolumento, CalculaDevolucao metodoDeCalculo)
        {
            return metodoDeCalculo(valorEmolumento);
        }

        static void executar()
        {
            DelMensagemSemRetornoESemParametro msg = Mensagem;
            msg();

            DelMensagemComRetornoESemParametro msg1 = MensagemComRetornoSemParametro;
            var mensagem = msg1();
            Console.WriteLine(mensagem);

            var XRegistro = new
            {
                IdentificadorRegistro = 123456,
                TipoRelatorio = 0,
                ChaveFonte = 4568,
                ValorEmolumento = 150.00,
                Descricao = "Pedido de Certidão"
            };

            var devolucao25PorCento = Calcular(XRegistro.ValorEmolumento, Calcula25PorCento);
            var devolucao75PorCento = Calcular(XRegistro.ValorEmolumento, Calcula75PorCento);

            Console.WriteLine($"Valor devolucção 25%: {devolucao25PorCento}");
            Console.WriteLine($"Valor devolucção 75%: {devolucao75PorCento}");


            DelMensagemSemRetornoEComParametro msg2 = MensagemSemRetornoEComParametro;
            msg2("Olá mundo");

            DelMensagemComRetornoEComParametro msg3 = MensagemComRetornoEComParametro;
            mensagem = msg3("Olá");
            Console.WriteLine(mensagem);

            DelSomaDoisNumeros soma = SomaDoisNumeros;
            var resultadoSoma = soma(2, 2);
            Console.WriteLine(resultadoSoma);

            DelMensagemSemRetornoESemParametro msgAnonimo = () =>
            {
                Console.WriteLine("Olá mundo");
            };

            msgAnonimo();

            DelMensagemComRetornoESemParametro msg1Anonimo = () =>
            {
                return "olá mundo";
            };

            Console.WriteLine(msg1Anonimo());

            DelMensagemSemRetornoEComParametro msg2Anonimo = (s) =>
            {
                Console.WriteLine(s);
            };

            msg2Anonimo("Olá mundo");

            DelMensagemComRetornoEComParametro msg3Anonimo = (s) =>
            {
                return s + " mundo";
            };
            mensagem = msg3Anonimo("Olá");
            Console.WriteLine(mensagem);

            DelSomaDoisNumeros somaAnonimo = (n1, n2) =>
            {
                return n1 + n2;
            };

            var resultadoSomaAnonimo = somaAnonimo(2, 2);
            Console.WriteLine(resultadoSomaAnonimo);

            Action msgAction = () =>
            {
                Console.WriteLine("Olá mundo");
            };

            msgAction();

            Action<string> msg2Action = (s) =>
            {
                Console.WriteLine(s);
            };

            msg2Action("Olá mundo");

            Func<string, string, string> msg3Func = (s, t) =>
            {
                return s + t;
            };
            mensagem = msg3Func("Olá", "Mundo");
            Console.WriteLine(mensagem);

            Func<int, int, int> somaFunc = (n1, n2) =>
            {
                return n1 + n2;
            };

            var resultadoSomaFunc = somaFunc(2, 2);
            Console.WriteLine(resultadoSomaFunc);

            Predicate<int> PessoaEDeMaior = (x) => x >= 18;

            Console.WriteLine(PessoaEDeMaior(18));

            Console.ReadKey();

            return;
        }
    }
}
