using System.Collections.Generic;

namespace VetClinicTestTask.WebApp.Data
{
    /// <summary>
    /// Описывает CRUD-операции
    /// </summary>
    /// <typeparam name="T">Сущность БД</typeparam>
    public interface IRepository<T> where T : class, IEntity
    {
        IEnumerable<T> GetAll();
        T Get(long id);
        void Add(T entity);
        void Update(T entity);
        T Delete(long id);
    }
}
