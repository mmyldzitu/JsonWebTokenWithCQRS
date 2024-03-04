using JWTAPP.BACK.Persistance.Context;
using JWTAPP.BACK.Persistance.Core.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace JWTAPP.BACK.Persistance.Repositories
{
    public class Repository<T> : IRepository<T> where T : class, new()
    {
        private readonly JwtAppContext _jwtAppContext;

        public Repository(JwtAppContext jwtAppContext)
        {
            _jwtAppContext = jwtAppContext;
        }

        public async Task CreateAsync(T entity)
        {
            await  _jwtAppContext.Set<T>().AddAsync(entity);
            await _jwtAppContext.SaveChangesAsync();
        }

        public async Task<List<T>> GetAllAsync()
        {
           return await _jwtAppContext.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T?> GetByFilter(Expression<Func<T, bool>> filter)
        {
            return await _jwtAppContext.Set<T>().AsNoTracking().SingleOrDefaultAsync(filter);
        }

        public async Task<T?> GetByIdAsync(object id)
        {
            return await _jwtAppContext.Set<T>().FindAsync(id);
        }

        public async Task RemoveAsync(T entity)
        {
             _jwtAppContext.Set<T>().Remove(entity);
            await _jwtAppContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _jwtAppContext.Set<T>().Update(entity); 
            await _jwtAppContext.SaveChangesAsync();
        }
    }
}
