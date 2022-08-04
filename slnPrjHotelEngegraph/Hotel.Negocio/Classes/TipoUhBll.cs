using Hotel.Comum.Dto;
using Hotel.Comum.Modelos;
using Hotel.Negocio.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Negocio.Classes
{
    public class TipoUhBll : BllBase, IBll<TipoUh>
    {
        public ObjValidacao Validar(TipoUh obj)
        {
            _resultadoValidacao.Criticas.Clear();

            if (string.IsNullOrWhiteSpace(obj.Descricao))
                _resultadoValidacao.Criticas.Add("Descrição deve ser informada.");
            
            if (obj.QtdeAdt <= 0)
                _resultadoValidacao.Criticas.Add("Quantidade de adultos deve ser maior que zero");
            
            if (obj.QtdeChd < 0)
                _resultadoValidacao.Criticas.Add("Quantidade de crianças inválida");
            
            if (obj.ValorDiaria <= 0)
                _resultadoValidacao.Criticas.Add("Informe um valor para a diária normal.");
            
            if (obj.ValorAdicional < 0)
                _resultadoValidacao.Criticas.Add("Valor adicional não pode ser negativo.");

            return _resultadoValidacao;

        }
    }
}
