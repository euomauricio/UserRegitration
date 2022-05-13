using Microsoft.EntityFrameworkCore;
using UserRegitration.Domain.Entities;
using UserRegitration.Infrastructure.Context;
using UserRegitration.Infrastructure.Interfaces;
namespace UserRegitration.Infrastructure.Repositories
{
    public class RepositoryBase<T> : IRepositoryAsync<T> where T : EntityBase
    {
        private readonly UserRegistrationContext _context;

        public RepositoryBase(UserRegistrationContext context)
        {
            _context = context;
        }

        public async Task Add(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<List<T>> Get()
        {
            return await _context.Set<T>().ToListAsync();        
        }

        public async Task<T> GetByGuid(Guid id)
        {
            return await _context.Set<T>().FirstAsync(x => Equals(x.Id, id));
        }

    }
}
