using BlazorServer.Components.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorServer.Components.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Profesor> Profesores => Set<Profesor>();
    }
}
