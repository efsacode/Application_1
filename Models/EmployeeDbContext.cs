using Microsoft.EntityFrameworkCore;

namespace Application1.Models
{
    public class EmployeeDbContext : DbContext
    {
        public DbSet<Employee> Employee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Veritabanı bağlantı dizesini buraya ekleyin
            optionsBuilder.UseSqlServer("Server=localhost;Database=EmployeeDB;Trusted_Connection=True;");
        }
    }
}
