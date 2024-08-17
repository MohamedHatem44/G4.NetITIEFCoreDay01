using G4.NetITIEFCoreDay01.Model;
using Microsoft.EntityFrameworkCore;

namespace G4.NetITIEFCoreDay01.Context
{
    public class CompanyContext : DbContext
    {
        // Configure EF RunTime To Connect To DataBase
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=G4.NetITIDataBase;Trusted_Connection=True;Encrypt=false;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Fluent Api
            //modelBuilder.Entity<Employee>().HasKey(e => e.Id);
            base.OnModelCreating(modelBuilder);
        }


        // Table => Employees
        // Only Mapped To DataBase
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
    }
}
