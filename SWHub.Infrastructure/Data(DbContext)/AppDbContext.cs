using Microsoft.EntityFrameworkCore;
using SmartWorkHub.Domain.Entities;

namespace SmartWorkHub.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users => Set<User>();
        public DbSet<Project> Projects => Set<Project>();
        public DbSet<TaskItem> Tasks => Set<TaskItem>();

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
