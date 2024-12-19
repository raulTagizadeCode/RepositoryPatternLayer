using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RepositoryPattern.DAL.Entities;

namespace RepositoryPattern.DAL.Contexts;

public class AppDBContext : DbContext
{
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Department> departments { get; set; }
    public AppDBContext(DbContextOptions<AppDBContext> option) : base(option)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());  
        base.OnModelCreating(modelBuilder);
    }
}
