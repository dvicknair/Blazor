using BlazorData.Models;
using BlazorData.Repositories;
using System.Threading.Tasks;

namespace BlazorData.UnitsOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BlazorContext _context;
        private IRepository<User> _userRepository;

        public UnitOfWork(BlazorContext context) => _context = context;
        public IRepository<User> UserRepository => _userRepository ??= new Repository<User>(_context);

        public async Task Commit() => await _context.SaveChangesAsync();
        public async void Dispose() => await _context.DisposeAsync();
    }
}
