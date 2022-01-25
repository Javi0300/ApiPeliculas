using Microsoft.EntityFrameworkCore;
using ApiPeliculas.Modelos;

namespace ApiPeliculas.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Peliculas> Peliculas { get; set; }
    }
}
