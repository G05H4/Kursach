using Microsoft.EntityFrameworkCore;

namespace WPF_EF_MVVM_SA_Proj.Resources.MVVM.Models.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Cabinet> Cabinets { get; set; }
        public DbSet<BusyCabinet> BusyCabinets { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Register> Registers { get; set; }

        public ApplicationContext() => Database.EnsureCreated();
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            //optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=SAMVVMEF;Trusted_Connection=True;");
            //optionsBuilder.UseSqlServer("Data Source=DESKTOP-I8L1GP6;Initial Catalog=SAMVVMEF;Integrated Security = True");
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-80EIJF9;Initial Catalog=Cabinets;");
        }
    }
}
