using Microsoft.AspNetCore.Mvc;
using MottFinder.Application.Dtos;
using MottFinder.Application.Interfaces;

namespace MottFinder.Presentation.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class GpsController : ControllerBase
    {
        private readonly IGpsService _gpsService;

        public GpsController(IGpsService gpsService)
        {
            _gpsService = gpsService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _gpsService.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var gps = await _gpsService.GetByIdAsync(id);
            return gps is null ? NotFound() : Ok(gps);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] GpsDto dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var created = await _gpsService.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] GpsDto dto)
        {
            var updated = await _gpsService.UpdateAsync(id, dto);
            return updated ? NoContent() : NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleted = await _gpsService.DeleteAsync(id);
            return deleted ? NoContent() : NotFound();
        }
    }
}
