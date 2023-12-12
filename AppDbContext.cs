using Assignment.Model;
using Microsoft.EntityFrameworkCore;

namespace Assignment
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
                var connectionString = configuration.GetConnectionString("dbConnection");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
       
        public DbSet<Enrollment> Enrollment { get; set; }

        public DbSet<Class> Class { get; set; }

        public DbSet<Faculty> Faculty { get; set; }

        public DbSet<Student> Student { get; set; }

        
    }
}
