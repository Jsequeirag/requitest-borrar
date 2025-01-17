using requitools_be.Context;
using requitools_be.Interfaces;
using requitools_be.Repositories;

namespace requitools_be
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RequiToolsDbContext _context;
        public UnitOfWork(RequiToolsDbContext context)
        {
            _context = context;
            Autores = new AutoresRepository(_context);
            
        }

        public IAutoresRepository Autores { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
