using Microsoft.EntityFrameworkCore;
using UserAPI.Models;

namespace UserAPI.Data
{
    public class UserAPIDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public UserAPIDbContext(DbContextOptions<UserAPIDbContext> options) : base(options) { }

    }
}
