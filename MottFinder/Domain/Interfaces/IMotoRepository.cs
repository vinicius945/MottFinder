using MottFinder.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MottFinder.Domain.Interfaces
{
    public interface IMotoRepository
    {
        Task<IEnumerable<Moto>> GetAllAsync();
        Task<Moto?> GetByIdAsync(int id);
        Task<IEnumerable<Moto>> GetByModeloAsync(string modelo);
        Task<Moto> CreateAsync(Moto moto);
        Task UpdateAsync(Moto moto);
        Task DeleteAsync(Moto moto);
    }
}
