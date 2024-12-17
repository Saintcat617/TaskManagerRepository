using Microsoft.EntityFrameworkCore;
using TaskManager.Api.Models;

namespace TaskManager.Api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        { }

        // Constructor sin parámetros para diseño
        public ApplicationDbContext() { }

        public DbSet<Usuario> Usuarios { get; set; } = null!;
        public DbSet<Tarea> Tareas { get; set; } = null!;
    }
}
