using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPISampleHandsOn.DataLayer;
using WebAPISampleHandsOn.Models;

namespace WebAPISampleHandsOn.Services.Repository
{
    public interface IRepository<T> where T:BaseEntity
    {
        IEnumerable<T> GetAll();
        T GetById(Guid id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(Guid id);
    }


    public class Repository<T> : IRepository<T> where T : BaseEntity
    {

        protected readonly ApplicationDbContext context;
        private DbSet<T> entities;
        string errorMessage = string.Empty;

        public Repository(ApplicationDbContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }
        public void Delete(Guid id)
        {
            if (id == null) throw new ArgumentNullException("entity");
            T entity = entities.SingleOrDefault(s => s.ID == id);
            entities.Remove(entity);
            context.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {

            return entities.AsEnumerable();
        }

        public T GetById(Guid id)
        {
            return entities.SingleOrDefault(s => s.ID == id);
        }

        public void Insert(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");

            entities.Add(entity);
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            context.SaveChanges();
        }
    }

}
