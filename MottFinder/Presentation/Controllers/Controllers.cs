using MottFinder.Application.Dtos;
using MottFinder.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MottFinder.Presentation.Controllers
{
    [ApiController]
    [Route("api/motos")]
    public class MotoController : ControllerBase
    {
        private readonly IMotoService _service;

        public MotoController(IMotoService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _service.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var moto = await _service.GetByIdAsync(id);
            return moto is null ? NotFound() : Ok(moto);
        }

        [HttpGet("buscar")]
        public async Task<IActionResult> GetByModelo([FromQuery] string modelo)
        {
            var motos = await _service.GetByModeloAsync(modelo);
            return motos.Any() ? Ok(motos) : NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] MotoDto dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var novaMoto = await _service.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = novaMoto.Id }, novaMoto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] MotoDto dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var updated = await _service.UpdateAsync(id, dto);
            return updated ? NoContent() : NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleted = await _service.DeleteAsync(id);
            return deleted ? NoContent() : NotFound();
        }
    }
}
