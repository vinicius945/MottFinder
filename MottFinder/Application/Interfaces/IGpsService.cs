using MottFinder.Application.Dtos;
using MottFinder.Domain.Entities;

namespace MottFinder.Application.Interfaces
{
    public interface IGpsService
    {
        Task<IEnumerable<Gps>> GetAllAsync();
        Task<Gps?> GetByIdAsync(int id);
        Task<Gps> CreateAsync(GpsDto dto);
        Task<bool> UpdateAsync(int id, GpsDto dto);
        Task<bool> DeleteAsync(int id);
    }
}
