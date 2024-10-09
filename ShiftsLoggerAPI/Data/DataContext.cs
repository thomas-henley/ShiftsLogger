using Microsoft.EntityFrameworkCore;
using ShiftsLoggerAPI.Entities;

namespace ShiftsLoggerAPI.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }
    
    public DbSet<Employee> Employees { get; set; }
}