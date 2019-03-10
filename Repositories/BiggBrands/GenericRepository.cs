using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ExportProductsToExcelFiles.Config;

namespace ExportProductsToExcelFiles.Repositories.BiggBrands
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {

        public BiggBrandsContext _entities;


        public GenericRepository(BiggBrandsContext context)
        {
            this._entities = context;
        }

        public virtual DbSet<T> GetAll()
        {

            return _entities.Set<T>();
        }

        public virtual List<T> FindAllItems()
        {

            return _entities.Set<T>().ToList();
        }


        public T FindById(Int64 id)
        {
            return _entities.Set<T>().Find(id);
        }

        public bool CheckById(Int64 id)
        {
            return _entities.Set<T>().Find(id) == null ? false : true;
        }

        public T FindByIdAsNoTracking(Int64 id)
        {
            T returnVal = _entities.Set<T>().Find(id);
            _entities.Entry(returnVal).State = EntityState.Detached;
            return returnVal;
        }

        public virtual T Add(T entity)
        {
            return _entities.Set<T>().Add(entity).Entity;
        }

        public virtual void AddRange(List<T> entities)
        {
            _entities.Set<T>().AddRange(entities);
        }

        public virtual void Delete(T entity)
        {
            _entities.Set<T>().Remove(entity);
        }

        public virtual void Edit(T entity)
        {
            _entities.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Save()
        {
            _entities.SaveChanges();
        }

        public virtual T Update(T entity)
        {
            _entities.Entry(entity).State = EntityState.Modified;
            return entity;
        }

        public virtual void UpdateRange(List<T> entities)
        {
            foreach (T entity in entities)
            {
                _entities.Entry(entity).State = EntityState.Modified;
            }
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {

            if (!this.disposed)
                if (disposing)
                    _entities.Dispose();

            this.disposed = true;
        }

        public void Dispose()
        {

            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}