using MottFinder.Application.Dtos;
using MottFinder.Application.Interfaces;
using MottFinder.Domain.Entities;
using MottFinder.Domain.Interfaces;

namespace MottFinder.Application.Services
{
    public class GpsService : IGpsService
    {
        private readonly IGpsRepository _repo;

        public GpsService(IGpsRepository repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<Gps>> GetAllAsync() => await _repo.GetAllAsync();

        public async Task<Gps?> GetByIdAsync(int id) => await _repo.GetByIdAsync(id);

        public async Task<Gps> CreateAsync(GpsDto dto)
        {
            var gps = new Gps
            {
                Latitude = dto.Latitude,
                Longitude = dto.Longitude,
                IdMoto = dto.IdMoto
            };
            return await _repo.CreateAsync(gps);
        }

        public async Task<bool> UpdateAsync(int id, GpsDto dto)
        {
            var gps = await _repo.GetByIdAsync(id);
            if (gps == null) return false;

            gps.Latitude = dto.Latitude;
            gps.Longitude = dto.Longitude;
            gps.IdMoto = dto.IdMoto;

            await _repo.UpdateAsync(gps);
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var gps = await _repo.GetByIdAsync(id);
            if (gps == null) return false;

            await _repo.DeleteAsync(gps);
            return true;
        }
    }
}
