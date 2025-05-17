using Microsoft.EntityFrameworkCore;
using MotFinder.Domain.Entities;
using MotFinder.Domain.Interfaces;
using MotFinder.Infrastructure.Data.AppData;


namespace MotFinder.Infrastructure.Data.Repositories
{
    public class MotoRepository : IMotoRepository
    {
        private readonly AppDataContext _context;

        public MotoRepository(AppDataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Moto>> GetAllAsync() => await _context.Motos.ToListAsync();

        public async Task<Moto?> GetByIdAsync(int id) => await _context.Motos.FindAsync(id);

        public async Task<IEnumerable<Moto>> GetByModeloAsync(string modelo) =>
            await _context.Motos.Where(m => m.Modelo.Contains(modelo)).ToListAsync();

        public async Task<Moto> CreateAsync(Moto moto)
        {
            _context.Motos.Add(moto);
            await _context.SaveChangesAsync();
            return moto;
        }

        public async Task UpdateAsync(Moto moto)
        {
            _context.Motos.Update(moto);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Moto moto)
        {
            _context.Motos.Remove(moto);
            await _context.SaveChangesAsync();
        }
    }
}
