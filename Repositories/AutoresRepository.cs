using Microsoft.EntityFrameworkCore;
using requitools_be.Context;
using requitools_be.Entities;
using requitools_be.Interfaces;
using System.Linq.Expressions;

namespace requitools_be.Repositories
{
    public class AutoresRepository : GenericRepository<Autores>, IAutoresRepository
    {
        public AutoresRepository(RequiToolsDbContext context) : base(context)
        {
        }

        public IEnumerable<Autores> GetAutoresBySQlquery(string query)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Autores> GetPopularAutores(int count)
        {
            throw new NotImplementedException();
        }
    }


     
    
}
