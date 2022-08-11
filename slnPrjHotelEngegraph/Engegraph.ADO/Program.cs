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
            Console.WriteLine("ACESSANDO DADOS COM ADO.NET");

            try
            {
                var ID = "75F7C398-752C-4D33-9439-8BA7D72174E8";

                var sql = $"SELECT * FROM TIPOUH WHERE ID = @ID";

                using (var conexao = new SqlConnection())
                {
                    conexao.ConnectionString = @"Server=2K21-DELL\SQLEXPRESS;Database=HotelEngegraph;User=sa;Password=123456";
                    var comando = new SqlCommand(sql, conexao);
                    comando.Parameters.AddWithValue("ID", ID);
                    conexao.Open();
                    Console.WriteLine("conectado ao banco de dados");

                    List<TipoUh> tiposUh = new List<TipoUh>();

                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tiposUh.Add(new TipoUh()
                            {
                                Id = (Guid)reader["Id"],
                                Descricao = reader["Descricao"].ToString(),
                                ValorDiaria = Convert.ToDouble(reader["ValorDiaria"])
                            });
                        }
                    }

                    foreach (var item in tiposUh)
                    {
                        Console.WriteLine($"Descrição: {item.Descricao}; Valor Diária: R$ {item.ValorDiaria.ToString("0.00")}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Leitura concluída com sucesso");
            Console.ReadKey();
        }
    }
}
