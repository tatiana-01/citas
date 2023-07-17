using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using Infrastructure.Data;
using Infrastructure.Repository;

namespace Infrastructure.UnitOfWork;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly CitasContext context;
    private GeneroRepository _generos;
    public UnitOfWork(CitasContext _context)
    {
        context = _context;
    }

    public IGeneroInterface Generos{
        get{
            if(_generos == null){
                _generos = new GeneroRepository(context);
            }
            return _generos;
        }
    }

    public void Dispose()
    {
        context.Dispose();
    }

    public Task<int> SaveAsync()
    {
        return context.SaveChangesAsync();
    }
}
