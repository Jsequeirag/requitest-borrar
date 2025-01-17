using requitools_be.Entities;

namespace requitools_be.Interfaces
{
    public interface IAutoresRepository : IGenericRepository<Autores>
    {
        IEnumerable<Autores> GetPopularAutores(int count);

        IEnumerable<Autores>GetAutoresBySQlquery(string query);
    }
}
