using MotFinder.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace MotFinder.Infrastructure.Data.AppData
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> options) : base(options) { }

        public DbSet<Moto> Motos { get; set; }
    }
}
