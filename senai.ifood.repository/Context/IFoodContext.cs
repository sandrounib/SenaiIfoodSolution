using Microsoft.EntityFrameworkCore;
using senai.ifood.domain;
using senai.ifood.domain.Entities;

namespace senai.ifood.repository.Context
{
    public class IFoodContext : DbContext
    {
        public IFoodContext(DbContextOptions<IFoodContext> options)
        : base(options)
        {
            
        }
        public DbSet<UsuarioDomain> Usuarios {get; set; }
        public DbSet<ClienteDomain> Clientes { get; set; }
        public DbSet<EspecialidadeDomain> Especialidades { get; set; }
        public DbSet<PermissaoDomain> Peermissoes { get; set; }
        public DbSet<ProdutoRestauranteDomain> ProdutosRestaurantes { get; set; }
        public DbSet<UsuarioPermissaoDomain> UsuariosPermissoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<ClienteDomain>().ToTable("Clientes");
            modelBuilder.Entity<EspecialidadeDomain>().ToTable("Especialidades");
            modelBuilder.Entity<PermissaoDomain>().ToTable("Permissoes");
            modelBuilder.Entity<ProdutoRestauranteDomain>().ToTable("ProdutosRestaurantes");
            modelBuilder.Entity<RestauranteDomain>().ToTable("Restaurantes");
            modelBuilder.Entity<UsuarioPermissaoDomain>().ToTable("UsuarioPermissoes");

            base.OnModelCreating(modelBuilder);

            

        }

        
    }
}