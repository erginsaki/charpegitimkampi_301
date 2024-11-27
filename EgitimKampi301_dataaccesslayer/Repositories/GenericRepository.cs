using EgitimKampi301_dataaccesslayer.Abstract;
using EgitimKampi301_dataaccesslayer.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimKampi301_dataaccesslayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        ProjectContext context = new ProjectContext();  
        private readonly DbSet<T> _object;

        public GenericRepository()
        {
            _object = context.Set<T>();
        }
        public void delete(T entity)
        {
            var deletedEntity = context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;//EntityStade ekleme silme vb. işlemleri yapmayı sağlayan bir kod bloğu.
            context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _object.ToList();
        }

        public T GetById(int id)
        {
            return _object.Find(id);
        }

        public void Insert(T entity)
        {
            var addedEntity = context.Entry(entity);
            addedEntity.State = EntityState.Added;
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            var updatedEntry = context.Entry(entity);   
            updatedEntry.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
