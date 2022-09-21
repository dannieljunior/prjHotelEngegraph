using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            //var pessoas = new List<Pessoa>()
            //{
            //    new Pessoa(){ Nome = "Daniel Ribeiro", Cpf = "77777777777"},
            //    new Pessoa(){ Nome = "Daniel Jr", Cpf = "99999999999"},
            //    new Pessoa(){ Nome = "Mariana", Cpf = "88888888888"},
            //};

            //var textoInformado = "Daniel";

            //var pessoaEncontrada = pessoas.Where(x => x.Nome.StartsWith(textoInformado));

            //pessoaEncontrada.ToList().ForEach(x =>
            //{
            //    Console.WriteLine($"Nome: {x.Nome}, Cpf: {x.Cpf}");
            //});

            //Console.ReadKey();

            Confirmar("Deseja realmente encerrar a aplicação? [S - Sim | N - Não]",
                (s) => {
                    Console.Beep();
                },
                (b) => {
                    Console.WriteLine("O usuário não quer encerrar a aplicação.");
                    Console.ReadKey();
                    }
                );
        }

        static void Confirmar(string Mensagem, Action<string> acaoSim, Action<bool> acaoNao)
        {
            var resposta = Console.ReadLine();
            if (resposta == "S")
                acaoSim("Texto");
            else
                acaoNao(false);
        }

    }
}
