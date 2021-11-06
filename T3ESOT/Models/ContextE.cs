using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T3ESOT.Models.Map;

namespace T3ESOT.Models
{
    public class ContextE : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Nota> Notas { get; set; }
        public DbSet<Etiqueta> Etiquetas { get; set; }
        public DbSet<EtiquetaNota> EtiquetaNotas { get; set; }
        public DbSet<Compartido> Compartidos { get; set; }
        public ContextE(DbContextOptions<ContextE> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new NotaMap());
            modelBuilder.ApplyConfiguration(new EtiquetaMap());
            modelBuilder.ApplyConfiguration(new EtiquetaNotaMap());
            modelBuilder.ApplyConfiguration(new CompartidoMap());

        }
    }
}
