

using Microsoft.EntityFrameworkCore;

namespace ConsoleApp2
{
    public class Db1Context : DbContext
    {
        public DbSet<Director> Directors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=va-5810-ws\\sqlexpress;Database=Testdb;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }

    public class Director
    {
        public int Id { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        
    }

    

}
