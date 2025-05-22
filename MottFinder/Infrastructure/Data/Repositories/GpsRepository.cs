using Microsoft.EntityFrameworkCore;
using MottFinder.Domain.Entities;
using MottFinder.Domain.Interfaces;
using MottFinder.Infrastructure.Data.AppData;

namespace MottFinder.Infrastructure.Data.Repositories
{
    public class GpsRepository : IGpsRepository
    {
        private readonly AppDataContext _context;

        public GpsRepository(AppDataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Gps>> GetAllAsync()
        {
            return await _context.Gps.ToListAsync();
        }

        public async Task<Gps?> GetByIdAsync(int id)
        {
            return await _context.Gps.FindAsync(id);
        }

        public async Task<Gps> CreateAsync(Gps gps)
        {
            _context.Gps.Add(gps);
            await _context.SaveChangesAsync();
            return gps;
        }

        public async Task UpdateAsync(Gps gps)
        {
            _context.Gps.Update(gps);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Gps gps)
        {
            _context.Gps.Remove(gps);
            await _context.SaveChangesAsync();
        }
    }
}
