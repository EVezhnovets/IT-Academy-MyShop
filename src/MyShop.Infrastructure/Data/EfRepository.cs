using Microsoft.EntityFrameworkCore;
using MyShop.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Infrastructure.Data
{
    public class EfRepository<T> : IRepository<T> where T : class
    {
        private readonly CatalogContext _dbContext;

        public EfRepository(CatalogContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<T> AddAsync(T entity)
        {
            var result = await _dbContext.AddAsync<T>(entity);
            _ = await _dbContext.SaveChangesAsync();
            return entity;  
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public T? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
