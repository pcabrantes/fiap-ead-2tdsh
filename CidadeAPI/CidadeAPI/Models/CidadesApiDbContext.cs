using Microsoft.EntityFrameworkCore;

namespace CidadeAPI.Models
{
    public class CidadesApiDbContext : DbContext
    {

        public CidadesApiDbContext(DbContextOptions<CidadesApiDbContext> options): base(options)
        {

        }

        public DbSet<Cidade> Cidades { get; set; }
    }
}
