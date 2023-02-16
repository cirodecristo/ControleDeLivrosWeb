using CadastroDeLivrosWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastroDeLivrosWeb.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=XPS13PLUS_CIRO\SQLEXPRESS; Initial Catalog=DB_Catalogo; User Id=sa; password=123456; TrustServerCertificate= True");
        }

    }
}
