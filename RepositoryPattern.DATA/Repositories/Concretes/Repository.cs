using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RepositoryPattern.DAL.Contexts;
using RepositoryPattern.DAL.Entities;
using RepositoryPattern.DAL.Repositories.Abstractions;

namespace RepositoryPattern.DAL.Repositories.Concretes
{
    public class Repository<T> : IRepository<T> where T : BaseEntity, new()
    {
        public readonly AppDBContext _appDBContext;

        public Repository(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        public DbSet<T> Table => _appDBContext.Set<T>();

        public async Task CreateAsync(T entity)
        {
            await Table.AddAsync(entity);
            int rows = await _appDBContext.SaveChangesAsync();
            if (rows == 0)
            {
                throw new Exception("Something went wrong");
            }

        }

        public async Task<List<T>> GetAllAsync()
        {
            List<T> values = await Table.ToListAsync();
            return values;
        }

        public async Task<T> GetByIdAsync(int id)
        {
            T? entity = await Table.FindAsync(id);
            if (entity == null)
            {
                throw new Exception($"Entity not fount id={id}");

            }
            return entity;
        }

    }
}
