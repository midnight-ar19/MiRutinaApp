using Microsoft.EntityFrameworkCore;
using MiRutina.Models;

namespace MiRutina.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Ejercicio> Ejercicios { get; set; }
        public DbSet<Rutina> Rutinas { get; set; }
        public DbSet<RutinaEjercicio> RutinaEjercicios { get; set; }

    }
}
