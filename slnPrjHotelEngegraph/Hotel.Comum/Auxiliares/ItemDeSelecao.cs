using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Comum.Auxiliares
{
    public class ItemDeSelecao<T>
    {
        public ItemDeSelecao(T valor, string descricao)
        {
            Valor = valor;
            Descricao = descricao;
        }
        public string Descricao { get; internal set; }
        public T Valor { get; internal set; }
    }
}
