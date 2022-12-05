using Microsoft.EntityFrameworkCore;
using SgbProject.Models;

namespace SgbProject.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Bovino> Bovinos { get; set; }
        public DbSet<Vacina> Vacinas { get; set; }
        public DbSet<Baixa> Baixas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
