using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using SoberBackend.Models;

namespace SoberBackend.Data
{
    public class SoberBackendDbContext : DbContext
    {
        public SoberBackendDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }


    }
}
