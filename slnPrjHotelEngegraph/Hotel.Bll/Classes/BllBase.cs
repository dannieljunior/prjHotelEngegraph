using Hotel.Bll.Interfaces;
using Hotel.Comum.Dto;
using Hotel.Comum.Enumerados;
using Hotel.Comum.Interfaces;
using Hotel.Comum.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Hotel.Bll.Classes
{
    public abstract class BllBase<T>: IBll<T> where T: Entidade
    {
        protected IRepositorio<T> _repositorio;

        public virtual T GetById(Guid id)
        {
            return _repositorio.GetById(id);
        }

        public virtual DataTable GetDataTable()
        {
            return _repositorio.GetDataTable();
        }

        public virtual T Persistir(T obj, EnOperacao operacao)
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

        public abstract ObjetoDeValidacao Validar(T objeto);
    }
}
