using Microsoft.EntityFrameworkCore;
using MottFinder.Domain.Entities;


namespace MottFinder.Infrastructure.Data.AppData
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> options) : base(options) { }

        public DbSet<Moto> Motos { get; set; }
    }
}
