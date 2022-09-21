using Hotel.Comum.Auxiliares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Comum.Helpers
{
    public static class ConfiguracaoHelpers
    {
        public static bool ToBoolean(this string value)
        {
            string[] valores = new string[] { Constantes.TRUE, Constantes.FALSE };
            if (valores.Any(x => x == value))
                return false;

            return value == Constantes.TRUE;
        }

        public static int ToInt(this string value)
        {
            try
            {
                return Convert.ToInt32(value);
            }
            catch
            {
                return 0;
            }
        }

        public static DateTime ToDateTime(this string value)
        {
            try
            {
                return Convert.ToDateTime(value);
            }
            catch 
            {
                throw new Exception("O valor não está em um formato datetime válido.");
            }
        }

        public static Double ToDouble(this string value)
        {
            try
            {
                return Convert.ToDouble(value);
            }
            catch
            {
                throw new Exception("O valor não está em um formato decimal válido.");
            }
        }
    }
}
