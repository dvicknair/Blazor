using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorData.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly BlazorContext _context;
        public Repository(BlazorContext context) => _context = context;

        public IEnumerable<T> Get(Func<T, bool> predicate) => _context.Set<T>().Where(predicate).ToList();
        public T GetSingle(Func<T, bool> predicate) => _context.Set<T>().Where(predicate).FirstOrDefault();
        public async Task<IEnumerable<T>> GetAll() => await _context.Set<T>().ToListAsync();
        public async Task<T> GetById(dynamic id) => await _context.Set<T>().FindAsync(id);

        public void Insert(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            _context.Add(entity);
        }
        public void Update(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            _context.Entry<T>(entity).State = EntityState.Modified;
        }
        public void Delete(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            _context.Remove(entity);
        }

        public async Task Commit() => await _context.SaveChangesAsync();
        public async void Dispose() => await _context.DisposeAsync();
    }
}
