using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Cliente.Eventos
{
    public class MyEventArgs: EventArgs
    {
        private readonly object _selectedId;
        public MyEventArgs(object obj)
        {
            _selectedId = obj;
        }

        public object SelectedItem => _selectedId;
    }
}
