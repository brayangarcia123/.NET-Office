using Microsoft.EntityFrameworkCore;
using OfficeWeb.Models;

namespace OfficeWeb.Data
{
    public class OfficeDB : DbContext
    {
        public OfficeDB(DbContextOptions<OfficeDB> options) : base(options)
        {

        }

        public DbSet<Employee> Employees => Set<Employee>();
    }
}
