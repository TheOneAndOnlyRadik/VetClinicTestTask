using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace VetClinicTestTask.WebApp.Data.EfCore
{
    public abstract class EfCoreRepository<TEntity, TContext> : IRepository<TEntity>
        where TEntity : class, IEntity
        where TContext : DbContext
    {
        private readonly TContext context;

        public EfCoreRepository(TContext context)
        {
            this.context = context;
        }

        protected virtual IQueryable<TEntity> QueryableSet
            => context.Set<TEntity>();

        public void Add(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);

            context.SaveChanges();
        }

        public TEntity Delete(long id)
        {
            TEntity entity = context.Set<TEntity>().Find(id);
            context.Set<TEntity>().Remove(entity);

            context.SaveChanges();

            return entity;
        }

        public TEntity Get(long id)
        {
            return QueryableSet.Where(e => e.Id == id).FirstOrDefault();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return QueryableSet.ToList();
        }

        public void Update(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            //context.Set<TEntity>().Update(entity);
            context.SaveChanges();
            //bool isDone = false;
            //while (!isDone)
            //{
            //    try
            //    {
            //        context.SaveChanges();
            //        isDone = true;
            //    }
            //    catch (DbUpdateConcurrencyException exc)
            //    {
            //        foreach (var entry in exc.Entries)
            //        {
            //            if (entry.Entity is TEntity)
            //            {
            //                var proposedValues = entry.CurrentValues;
            //                var databaseValues = entry.GetDatabaseValues();

            //                foreach (var property in proposedValues.Properties)
            //                {
            //                    var proposedValue = proposedValues[property];
            //                    var databaseValue = databaseValues[property];
            //                }

            //                entry.OriginalValues.SetValues(databaseValues);
            //            }
            //        }
            //}
        }
    }
}
