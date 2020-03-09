using Microsoft.EntityFrameworkCore;


namespace Entity_Frame_Linq
{
    public class AnimalContext : DbContext
    {
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Species> Species { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Server = AG\SQLEXPRESS;Database = Animals; Integrated Security=True");
        }

    }
}
