using ManagerEmployeeNeoCharacter.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ManagerEmployeeNeoCharacter.DAL
{
    public class ManagerEmployeeNeoCharacterContext  : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Neo> Neos { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Statuss> Statusss { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}