

using System.Linq.Expressions;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class GeneroRepository : IGeneroInterface
{
    protected readonly CitasContext _context;
    public GeneroRepository(CitasContext context)
    {
        _context = context;
    }
    public virtual void Add(Genero entity)
    {
        _context.Set<Genero>().Add(entity);
    }
    public virtual void AddRange(IEnumerable<Genero> entities)
    {
        _context.Set<Genero>().AddRange(entities);
    }
    public IEnumerable<Genero> Find(Expression<Func<Genero, bool>> expression)
    {
        return _context.Set<Genero>().Where(expression);
    }
    public async Task<IEnumerable<Genero>> GetAllAsync()
    {
        return await _context.Set<Genero>().ToListAsync();
    }
    public async Task<Genero> GetByIdAsync(int id)
    {
        return await _context.Set<Genero>().FindAsync(id);
    }
    public void Remove(Genero entity)
    {
        _context.Set<Genero>().Remove(entity);
    }

    public void RemoveRange(IEnumerable<Genero> entities)
    {
        _context.Set<Genero>().RemoveRange(entities);
    }

    public void update(Genero entity)
    {
        _context.Set<Genero>().Update(entity);
    }
}
