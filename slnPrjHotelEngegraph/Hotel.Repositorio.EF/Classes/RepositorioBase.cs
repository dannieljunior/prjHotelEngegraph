using Hotel.Comum.Interfaces;
using Hotel.Comum.IOC;
using Hotel.Comum.Modelos;
using Ninject;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Hotel.Repositorio.EF.Classes
{
    public abstract class RepositorioBase<T> : IRepositorio<T> where T : Entidade
    {
        protected readonly HotelDbContext context;
        protected DbSet<T> dbset;
        public RepositorioBase()
        {
            context = Kernel.Get<HotelDbContext>();
        }  

        public void Delete(Guid id)
        {
            var obj = GetById(id);
            dbset.Remove(obj);
            context.SaveChanges();
        }

        public T GetById(Guid id)
        {
            return dbset.Find(id);
        }

        public T Insert(T obj)
        {
            obj.Id = Guid.NewGuid();
            obj.DataCriacao = DateTime.Now;
            dbset.Add(obj);
            context.SaveChanges();
            return obj;
        }

        public virtual List<T> List()
        {
            return dbset.ToList();
        }

        public virtual List<T> List(Func<T, bool> query)
        {
            return dbset.Where(query).ToList();
        }

        public void Update(T obj)
        {
            if (obj.Id == null || obj.Id == default(Guid))
                throw new Exception("Id não defindido para atualizar o registro");

            obj.DataModificacao = DateTime.Now;
            dbset.AddOrUpdate(obj);

            context.SaveChanges();
        }
    }
}
