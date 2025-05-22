using MottFinder.Application.Dtos;
using MottFinder.Domain.Entities;

namespace MottFinder.Application.Interfaces
{
    public interface ICameraService
    {
        Task<IEnumerable<Camera>> GetAllAsync();
        Task<Camera?> GetByIdAsync(int id);
        Task<Camera> CreateAsync(CameraDto dto);
        Task<bool> UpdateAsync(int id, CameraDto dto);
        Task<bool> DeleteAsync(int id);
    }
}
