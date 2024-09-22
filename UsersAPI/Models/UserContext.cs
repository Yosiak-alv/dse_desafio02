using Microsoft.EntityFrameworkCore;

namespace UsersAPI.Models
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options) { }

        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Datos semilla (Seed data) para usuarios
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Name = "John Doe",
                    Email = "john@example.com",
                    Password = "password"
                },
                new User
                {
                    Id = 2,
                    Name = "Jane Doe",
                    Email = "jane@example.com",
                    Password = "password"
                }
            );
        }
    }
}
