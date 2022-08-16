using Hotel.Comum.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engegraph.ADO
{
    class Program
    {
        static void Main(string[] args)
        {

            string stringNula = null;


            Console.WriteLine(stringNula ?? "A string está nula");



            //try
            //{
            //    using (var conexao = new SqlConnection(@"Server=2K21-DELL\SQLEXPRESS;Database=HotelEngegraph;User=sa;Password=123456"))
            //    {
                    
            //        Console.WriteLine("Meu primeiro CRUD completo");

            //        var crud = new TipoUhCrud(conexao);

            //        var tipoUh = new TipoUh();

            //        tipoUh.Id = new Guid("9bf65609-1c0f-4bfb-be31-4c633847a5ac");
            //        tipoUh.Descricao = "Super Lux Suite";
            //        tipoUh.QtdeAdt = 2;
            //        tipoUh.QtdeChd = 2;
            //        tipoUh.ValorDiaria = 499.00;
            //        tipoUh.ValorAdicional = 699.00;

            //        crud.Create(tipoUh);

            //        Console.WriteLine("Dados inseridos com sucesso");

            //        Console.WriteLine("Lendo dados do banco ...");

            //        var dados = crud.Read(new FiltroTipoUH() { Id = "75F7C398-752C-4D33-9439-8BA7D72174E8", Descricao = "S" });

            //        foreach (var item in dados)
            //        {
            //            Console.WriteLine($"Id: {item.Id}");
            //            Console.WriteLine($"Descricao: {item.Descricao}");
            //            Console.WriteLine($"QtdeAdt: {item.QtdeAdt}");
            //            Console.WriteLine($"QtdeChd: {item.QtdeChd}");
            //            Console.WriteLine($"ValorDiaria: {item.ValorDiaria}");
            //            Console.WriteLine($"ValorAdicional: {item.ValorAdicional}");
            //            Console.WriteLine($"DataCriacao: {item.DataCriacao}");
            //            Console.WriteLine($"DataModificacao: {item.DataModificacao}");
            //            Console.WriteLine("---------------------------------------------------------------------------------------");
            //        }


            //        tipoUh.Id = new Guid("9bf65609-1c0f-4bfb-be31-4c633847a5ac");
            //        tipoUh.Descricao = "SUPER LUX SUITE";
            //        tipoUh.QtdeAdt = 2;
            //        tipoUh.QtdeChd = 2;
            //        tipoUh.ValorDiaria = 699.00;
            //        tipoUh.ValorAdicional = 899.00;

            //        crud.Update(tipoUh);

            //        var id = new Guid("9bf65609-1c0f-4bfb-be31-4c633847a5ac");

            //        crud.Delete(id);

            //        Console.WriteLine("Registro excluído com sucesso!"); 
            //    }

            //}
            //catch(Exception ex)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.ReadKey();
            //}
        }
    }
}
