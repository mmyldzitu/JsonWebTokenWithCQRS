using Microsoft.EntityFrameworkCore;
using Onion.JWTAPP.Application.Interfaces;
using Onion.JWTAPP.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Onion.JWTAPP.Persistence.Repositories
{
    public class Repository<T> : IRepository<T> where T : class, new()
    {
        private readonly JwtContext _jwtContext;

        public Repository(JwtContext jwtContext)
        {
            _jwtContext = jwtContext;
        }

        public  async Task<T?> CreateAsync(T entity)
        {
            await _jwtContext.Set<T>().AddAsync(entity);
            await _jwtContext.SaveChangesAsync();
            return entity;
        }

        public async  Task<List<T>> GetAllAsync()
        {
            return await _jwtContext.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T?> GetByFilterAsync(Expression<Func<T, bool>> filter)
        {
            return await _jwtContext.Set<T>().AsNoTracking().SingleOrDefaultAsync(filter);
        }

        public async  Task<T?> GetByIdAsync(object id)
        {
            return await _jwtContext.Set<T>().FindAsync(id);
        }

        public async Task Remove(T entity)
        {
          _jwtContext.Set<T>().Remove(entity);
            await _jwtContext.SaveChangesAsync();
        }

        public async Task<int> SaveChangesAsync()
        {
           return await _jwtContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _jwtContext.Set<T>().Update(entity);
            await _jwtContext.SaveChangesAsync();
            
        }
    }
}
