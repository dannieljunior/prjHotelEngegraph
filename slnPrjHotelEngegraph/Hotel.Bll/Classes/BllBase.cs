using Hotel.Bll.Interfaces;
using Hotel.Comum.Dto;
using Hotel.Comum.Enumerados;
using Hotel.Comum.Interfaces;
using Hotel.Comum.Modelos;
using Hotel.Repositorio.ADO.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Hotel.Bll.Classes
{
    public abstract class BllBase<T, R>: IBll<T> where T: Entidade 
                                                 where R : IRepositorio<T>
    {
        protected R _repositorio;

        public virtual T GetById(Guid id)
        {
            return _repositorio.GetById(id);
        }

        public virtual List<T> List()
        {
            return _repositorio.List();
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
