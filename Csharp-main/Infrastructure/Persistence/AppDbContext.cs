using Microsoft.EntityFrameworkCore;
using challenge_dotnet.Domain.MotoRepository;

namespace Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Moto> Motos { get; set; }
        public DbSet<Filial> Filiais { get; set; }
        public DbSet<LocalizacaoPatio> Localizacoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Nome explícito das tabelas no banco Oracle
            modelBuilder.Entity<Moto>().ToTable("MOTOS");
            modelBuilder.Entity<Filial>().ToTable("FILIAIS");
            modelBuilder.Entity<LocalizacaoPatio>().ToTable("LOCALIZACOES_PATIO");
        }
    }
}
