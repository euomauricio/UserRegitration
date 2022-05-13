using Microsoft.EntityFrameworkCore;
using UserRegitration.Domain.Entities;

namespace UserRegitration.Infrastructure.Context
{
    public class UserRegistrationContext : DbContext
    {
        public UserRegistrationContext(DbContextOptions options) : base(options) { }

        public DbSet<UserEntity> UserEntity { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
