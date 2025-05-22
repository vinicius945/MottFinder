using MottFinder.Domain.Entities;

namespace MottFinder.Domain.Interfaces
{
    public interface ICameraRepository
    {
        Task<IEnumerable<Camera>> GetAllAsync();
        Task<Camera?> GetByIdAsync(int id);
        Task<Camera> CreateAsync(Camera camera);
        Task UpdateAsync(Camera camera);
        Task DeleteAsync(Camera camera);

    }
}
