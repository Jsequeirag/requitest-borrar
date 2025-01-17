namespace requitools_be.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IAutoresRepository Autores { get; }

        int Complete();
    }
}
