using Hotel.Bll.Interfaces;
using Hotel.Comum.Dto;
using Hotel.Comum.Enumerados;
using Hotel.Comum.Modelos;
using Hotel.Repositorio.ADO.Classes;
using System;
using System.Data;

namespace Hotel.Bll.Classes
{
    public class TipoUhBll : BllBase<TipoUh>, IBll<TipoUh>
    {
        public TipoUhBll()
        {
            _repositorio = new RepositorioADOTipoUh();
        }

        public TipoUh GetById(Guid id)
        {
            return _repositorio.GetById(id);
        }

        public DataTable GetDataTable()
        {
            return _repositorio.GetDataTable();
        }

        public TipoUh Persistir(TipoUh obj, EnOperacao operacao)
        {
            switch (operacao)
            {
                case EnOperacao.Insert: return _repositorio.Insert(obj);
                case EnOperacao.Update:
                    {
                        _repositorio.Update(obj);
                        return null;
                    }
                case EnOperacao.Delete:
                    {
                        _repositorio.Delete(obj.Id);
                        return null;
                    }
                default:
                    break; throw new Exception("Operação indefinida");
            }

            return null;
        }

        public ObjetoDeValidacao Validar(TipoUh objeto)
        {
            var result = new ObjetoDeValidacao();

            if (string.IsNullOrWhiteSpace(objeto.Descricao))
            {
                result.Criticas.Add("Descrição deve ser informada.");
            }

            if(objeto.QtdeAdt <= 0)
            {
                result.Criticas.Add("Quantidade de adultos deve ser maior que zero.");
            }

            if(objeto.QtdeChd < 0)
            {
                result.Criticas.Add("Quantidade de crianças não pode ser negativa.");
            }

            if(objeto.ValorDiaria <= 0)
            {
                result.Criticas.Add("Valor da diária deve ser informado");
            }

            if (objeto.ValorAdicional < 0)
            {
                result.Criticas.Add("Valor adicional não pode ser um valor negativo.");
            }

            return result;
        }
    }
}
