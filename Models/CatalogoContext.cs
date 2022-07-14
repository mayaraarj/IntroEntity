using Microsoft.EntityFrameworkCore;

namespace IntroEntity.Models

{
    public class CatalogoContext : DbContext
    {
        public CatalogoContext(DbContextOptions<CatalogoContext> options)
            : base(options)
        {
        }

        public DbSet<Filmes> Filmes { get; set; }
        public DbSet<Ator> Atores { get; set; }
    }
}
