using MottFinder.Application.Dtos;
using MottFinder.Application.Interfaces;
using MottFinder.Domain.Entities;
using MottFinder.Domain.Interfaces;

namespace MottFinder.Application.Services
{
    public class CameraService : ICameraService
    {
        private readonly ICameraRepository _repo;

        public CameraService(ICameraRepository repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<Camera>> GetAllAsync() => await _repo.GetAllAsync();

        public async Task<Camera?> GetByIdAsync(int id) => await _repo.GetByIdAsync(id);

        public async Task<Camera> CreateAsync(CameraDto dto)
        {
            var camera = new Camera
            {
                Posicao = dto.Posicao,
                IdMoto = dto.IdMoto
            };
            return await _repo.CreateAsync(camera);
        }

        public async Task<bool> UpdateAsync(int id, CameraDto dto)
        {
            var camera = await _repo.GetByIdAsync(id);
            if (camera == null) return false;

            camera.Posicao = dto.Posicao;
            camera.IdMoto = dto.IdMoto;

            await _repo.UpdateAsync(camera);
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var camera = await _repo.GetByIdAsync(id);
            if (camera == null) return false;

            await _repo.DeleteAsync(camera);
            return true;
        }
    }
}
