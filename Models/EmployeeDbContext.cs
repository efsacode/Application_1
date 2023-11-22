using Microsoft.EntityFrameworkCore;

namespace Application1.Models
{
    public class EmployeeDbContext : DbContext
    {
        public DbSet<Employee> Employee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer("Data Source=(local)\\SQLEXPRESS;Initial Catalog=EmployeeDB;Integrated Security=True");
        }
    }
}
