using Microsoft.EntityFrameworkCore;
using TiendaMLG.Entities.Models;

namespace TiendaMLG.Data.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        // Definición de las tablas
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Tienda> Tiendas { get; set; }
        public DbSet<Articulo> Articulos { get; set; }
        public DbSet<ArticuloTienda> ArticuloTiendas { get; set; }
        public DbSet<ClienteArticulo> ClienteArticulos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Evita nombres en plural para las tablas en la base de datos
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<Tienda>().ToTable("Tiendas");
            modelBuilder.Entity<Articulo>().ToTable("Articulo");
            modelBuilder.Entity<ArticuloTienda>().ToTable("ArticuloTienda");
            modelBuilder.Entity<ClienteArticulo>().ToTable("ClienteArticulo");

            // Configuración de la relación ArticuloTienda (Muchos a Muchos)
            modelBuilder.Entity<ArticuloTienda>()
                .HasKey(at => new { at.ArticuloID, at.TiendaID });

            modelBuilder.Entity<ArticuloTienda>()
                .HasOne(at => at.Articulo)
                .WithMany(a => a.ArticuloTiendas)
                .HasForeignKey(at => at.ArticuloID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ArticuloTienda>()
                .HasOne(at => at.Tienda)
                .WithMany(t => t.ArticuloTiendas)
                .HasForeignKey(at => at.TiendaID)
                .OnDelete(DeleteBehavior.Restrict);

            // Configuración de la relación ClienteArticulo (Muchos a Muchos)
            modelBuilder.Entity<ClienteArticulo>()
                .HasKey(ca => new { ca.ClienteID, ca.ArticuloID });

            modelBuilder.Entity<ClienteArticulo>()
                .HasOne(ca => ca.Cliente)
                .WithMany(c => c.ClienteArticulos)
                .HasForeignKey(ca => ca.ClienteID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ClienteArticulo>()
                .HasOne(ca => ca.Articulo)
                .WithMany(a => a.ClienteArticulos)
                .HasForeignKey(ca => ca.ArticuloID)
                .OnDelete(DeleteBehavior.Restrict);

            // Configuración de la columna Precio en Articulo
            modelBuilder.Entity<Articulo>()
                .Property(a => a.Precio)
                .HasColumnType("decimal(18,2)");
        }
    }
}
