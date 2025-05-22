using Microsoft.EntityFrameworkCore;
using MottFinder.Domain.Entities;
using MottFinder.Domain.Interfaces;
using MottFinder.Infrastructure.Data.AppData;

namespace MottFinder.Infrastructure.Data.Repositories
{
    public class CameraRepository : ICameraRepository
    {
        private readonly AppDataContext _context;

        public CameraRepository(AppDataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Camera>> GetAllAsync()
        {
            return await _context.Cameras.ToListAsync();
        }

        public async Task<Camera?> GetByIdAsync(int id)
        {
            return await _context.Cameras.FindAsync(id);
        }

        public async Task<Camera> CreateAsync(Camera camera)
        {
            _context.Cameras.Add(camera);
            await _context.SaveChangesAsync();
            return camera;
        }

        public async Task UpdateAsync(Camera camera)
        {
            _context.Cameras.Update(camera);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Camera camera)
        {
            _context.Cameras.Remove(camera);
            await _context.SaveChangesAsync();
        }
    }
}
