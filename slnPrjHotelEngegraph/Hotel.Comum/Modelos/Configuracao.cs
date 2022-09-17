﻿using Hotel.Comum.Enumerados;

namespace Hotel.Comum.Modelos
{
    public class Configuracao: Entidade
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public string Valor { get; set; }
        public EnTipoConfiguracao Tipo { get; set; }
    }
}
