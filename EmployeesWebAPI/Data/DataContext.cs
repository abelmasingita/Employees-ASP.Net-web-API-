using EmployeesWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeesWebAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
