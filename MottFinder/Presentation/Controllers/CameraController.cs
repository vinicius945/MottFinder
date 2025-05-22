using Microsoft.AspNetCore.Mvc;
using MottFinder.Application.Dtos;
using MottFinder.Application.Interfaces;

namespace MottFinder.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CameraController : ControllerBase
    {
        private readonly ICameraService _cameraService;

        public CameraController(ICameraService cameraService)
        {
            _cameraService = cameraService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _cameraService.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var camera = await _cameraService.GetByIdAsync(id);
            return camera is null ? NotFound() : Ok(camera);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CameraDto dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var created = await _cameraService.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] CameraDto dto)
        {
            var updated = await _cameraService.UpdateAsync(id, dto);
            return updated ? NoContent() : NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleted = await _cameraService.DeleteAsync(id);
            return deleted ? NoContent() : NotFound();
        }

    }
}
