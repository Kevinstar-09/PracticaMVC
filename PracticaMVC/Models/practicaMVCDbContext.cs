using Microsoft.EntityFrameworkCore;
using PracticaMVC.Models;

namespace PracticaMVC.Models
{
    public class practicaMVCDbContext : DbContext
    {
        public practicaMVCDbContext(DbContextOptions options) : base(options) 
        { 
        }
        public DbSet<marcas> marcas { get; set; }
        public DbSet<PracticaMVC.Models.alumnos> alumnos { get; set; } = default!;
        public DbSet<PracticaMVC.Models.departamentos> departamentos { get; set; } = default!;
        public DbSet<PracticaMVC.Models.facultades> facultades { get; set; } = default!;
        public DbSet<PracticaMVC.Models.materias> materias { get; set; } = default!;
    }
}
