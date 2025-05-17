using MottFinder.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MottFinder.Application.Dtos;
using MottFinder.Domain.Entities;
using MottFinder.Domain.Interfaces;


namespace MottFinder.Application.Services
{
    public class MotoService : IMotoService
    {
        private readonly IMotoRepository _repo;

        public MotoService(IMotoRepository repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<Moto>> GetAllAsync() => await _repo.GetAllAsync();

        public async Task<Moto?> GetByIdAsync(int id) => await _repo.GetByIdAsync(id);

        public async Task<IEnumerable<Moto>> GetByModeloAsync(string modelo) => await _repo.GetByModeloAsync(modelo);

        public async Task<Moto> CreateAsync(MotoDto dto)
        {
            var moto = new Moto
            {
                Modelo = dto.Modelo,
                Localizacao = dto.Localizacao,
                Status = dto.Status
            };
            return await _repo.CreateAsync(moto);
        }

        public async Task<bool> UpdateAsync(int id, MotoDto dto)
        {
            var moto = await _repo.GetByIdAsync(id);
            if (moto == null) return false;

            moto.Modelo = dto.Modelo;
            moto.Localizacao = dto.Localizacao;
            moto.Status = dto.Status;

            await _repo.UpdateAsync(moto);
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var moto = await _repo.GetByIdAsync(id);
            if (moto == null) return false;

            await _repo.DeleteAsync(moto);
            return true;
        }
    }
}
