using MottFinder.Application.Dtos;
using MottFinder.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MottFinder.Application.Interfaces
{
    public interface IMotoService
    {
        Task<IEnumerable<Moto>> GetAllAsync();
        Task<Moto?> GetByIdAsync(int id);
        Task<IEnumerable<Moto>> GetByModeloAsync(string modelo);
        Task<Moto> CreateAsync(MotoDto dto);
        Task<bool> UpdateAsync(int id, MotoDto dto);
        Task<bool> DeleteAsync(int id);

    }
}
