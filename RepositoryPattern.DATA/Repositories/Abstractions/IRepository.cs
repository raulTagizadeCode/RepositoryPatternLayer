using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RepositoryPattern.DAL.Entities;

namespace RepositoryPattern.DAL.Repositories.Abstractions
{
    public interface IRepository<T> where T : BaseEntity, new()
    {
        DbSet<T> Table { get; }

        Task<T> GetByIdAsync(int id);
        Task CreateAsync(T entity);
        Task<List<T>> GetAllAsync();
    }
}
