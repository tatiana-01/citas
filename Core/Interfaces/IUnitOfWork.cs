
namespace Core.Interfaces;

    public interface IUnitOfWork
    {
        IGeneroInterface Generos {get;}
        int Save();
    }
