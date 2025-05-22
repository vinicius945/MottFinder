using MottFinder.Domain.Entities;

namespace MottFinder.Domain.Interfaces
{
    public interface IGpsRepository
    {
        Task<IEnumerable<Gps>> GetAllAsync();
        Task<Gps?> GetByIdAsync(int id);
        Task<Gps> CreateAsync(Gps gps);
        Task UpdateAsync(Gps gps);
        Task DeleteAsync(Gps gps);

    }
}
