using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorData.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(dynamic id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task Commit();
        void Dispose();
        IEnumerable<T> Get(Func<T, bool> predicate);
        T GetSingle(Func<T, bool> predicate);
    }
}
