
namespace Core.Interfaces;

    public interface IUnitOfWork
    {
        IGeneroInterface Generos {get;}
        Task<int> SaveAsync();
    }
